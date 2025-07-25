using System.Reflection;
using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.EncodableData;
using ProtankiNetworking.Packets.Entry;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets;

/// <summary>
/// Every field or property that has this atribute will be encoded when the object is encoded.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class EncodeAttribute : Attribute
{
	public int Order { get; set; }

	public EncodeAttribute(int order = 0)
	{
		Order = order;
	}
}

/// <summary>
/// Used for encoding and decoding packets.
/// </summary>
public static class PacketCoder
{
	private static Dictionary<Type, ICodec> codecs = new();

	/// <summary>
	/// Registers the built-in primitive codecs to the internal codec dictionary.
	/// </summary>
	static PacketCoder()
	{
		RegisterCodec(BoolCodec.Instance);
		RegisterCodec(ByteCodec.Instance);
		RegisterCodec(FloatCodec.Instance);
		RegisterCodec(IntCodec.Instance);
		RegisterCodec(ShortCodec.Instance);
		RegisterCodec(JsonCodec.Instance);
		RegisterCodec(StringCodec.Instance);
		RegisterCodec(Vector3DCodec.Instance);
	}

	/// <summary>
	/// Registers a codec for a specific type.
	/// </summary>
	/// <param name="codec">The codec instance to register.</param>
	public static void RegisterCodec(ICodec codec)
	{
		codecs[codec.TargetType] = codec;
	}

	/// <summary>
	/// Encodes a packet into a byte array, applying optional encryption.
	/// </summary>
	/// <param name="packet">The packet to encode.</param>
	/// <param name="protection">Optional protection mechanism to encrypt the packet.</param>
	/// <returns>Encoded and optionally encrypted byte array.</returns>
	/// <exception cref="Exception">Thrown if the packet is of type UnknownPacket.</exception>
	public static EByteArray EncodePacket(Packet packet, Protection? protection)
	{
		if (packet is UnknownPacket)
		{
			throw new Exception("Cannot wrap UnknownPacket");
		}

		int dataLen = Packet.HEADER_LEN;
		EByteArray packetData = new();

		EncodeObject(packet, packetData);

		byte[] encryptedData =
			protection?.Encrypt(packetData.ToTrimmedArray()) ?? packetData.ToTrimmedArray();
		EByteArray result = new();
		result.WriteInt(dataLen);
		result.WriteInt(packet.Id);
		result.Write(encryptedData);
		return result;
	}

	/// <summary>
	/// Encodes all fields and properties of an object marked with [Encode] into a buffer.
	/// </summary>
	/// <param name="obj">The object to encode.</param>
	/// <param name="buffer">The target buffer to write encoded data into.</param>
	/// <returns>The number of bytes written.</returns>
	private static int EncodeObject(object obj, EByteArray buffer)
	{
		if (obj == null)
			throw new ArgumentNullException(nameof(obj));

		int totalBytes = 0;
		Type type = obj.GetType();

		var fields = type.GetFields(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(f => f.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(f => f.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var field in fields)
		{
			object? value = field.GetValue(obj);
			Type fieldType = field.FieldType;

			totalBytes += EncodeValue(fieldType, value, buffer);
		}

		var properties = type.GetProperties(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(p => p.CanRead && p.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(p => p.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var prop in properties)
		{
			object? value = prop.GetValue(obj);
			Type propType = prop.PropertyType;

			totalBytes += EncodeValue(propType, value, buffer);
		}

		return totalBytes;
	}

	/// <summary>
	/// Encodes a single value of a given type into the buffer.
	/// </summary>
	/// <param name="type">The type of the value.</param>
	/// <param name="value">The value to encode.</param>
	/// <param name="buffer">The buffer to write to.</param>
	/// <returns>The number of bytes written.</returns>
	private static int EncodeValue(Type type, object? value, EByteArray buffer)
	{
		Type actualType = Nullable.GetUnderlyingType(type) ?? type;
		int bytesWritten = 0;

		// Case 1: Manually defined codec
		if (codecs.TryGetValue(type, out var codec))
		{
			bytesWritten += codec.Encode(value, buffer);
		}
		// Case 2: Enum
		else if (actualType.IsEnum)
		{
			int intValue = Convert.ToInt32(value);
			bytesWritten += IntCodec.Instance.Encode(intValue, buffer);
		}
		// Case 3: Array
		else if (type.IsArray && type.GetElementType() is Type elementType)
		{
			object?[] array =
				(value as Array)?.Cast<object?>().ToArray()
				?? throw new ArgumentException("Invalid array value");

			codecs.TryGetValue(elementType, out var elementCodec);
			bool shorten = false;

			if (typeof(IEncodable).IsAssignableFrom(elementType))
			{
				PropertyInfo? isArrayOptionalProp = elementType.GetProperty(
					"IsArrayOptional",
					BindingFlags.Public | BindingFlags.Static
				);
				if (isArrayOptionalProp != null && isArrayOptionalProp.PropertyType == typeof(bool))
				{
					shorten = (bool)isArrayOptionalProp.GetValue(null)!;
				}
			}

			if (!(elementCodec is null))
			{
				shorten = elementCodec.IsArrayOptional;
			}

			if (shorten && array == null)
				return BoolCodec.Instance.Encode(true, buffer);

			if (shorten)
				bytesWritten += BoolCodec.Instance.Encode(false, buffer);

			bytesWritten += IntCodec.Instance.Encode(array.Length, buffer);
			if (!(elementCodec is null))
			{
				foreach (var item in array)
				{
					bytesWritten += elementCodec.Encode(item, buffer);
				}
			}
			else
			{
				foreach (var item in array)
				{
					bytesWritten += EncodeObject(item!, buffer);
				}
			}
		}
		// Case 4: Complex type
		else
		{
			bytesWritten += EncodeObject(value!, buffer);
		}

		return bytesWritten;
	}

	/// <summary>
	/// Decodes a packet's content into an existing packet instance.
	/// </summary>
	/// <param name="packetData">The data to decode.</param>
	/// <param name="packet">The target packet instance to fill.</param>
	public static void DecodePacket(EByteArray packetData, Packet packet)
	{
		DecodeObjectInto(packet, packetData);
	}

	/// <summary>
	/// Decodes data from a buffer into an existing object by assigning values to its fields and properties.
	/// </summary>
	/// <param name="target">The existing object to populate.</param>
	/// <param name="buffer">The buffer containing encoded data.</param>
	private static void DecodeObjectInto(object target, EByteArray buffer)
	{
		Type type = target.GetType();

		var fields = type.GetFields(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(f => f.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(f => f.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var field in fields)
		{
			object? value = DecodeValue(field.FieldType, buffer);
			field.SetValue(target, value);
		}

		var properties = type.GetProperties(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(p => p.CanWrite && p.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(p => p.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var prop in properties)
		{
			object? value = DecodeValue(prop.PropertyType, buffer);
			prop.SetValue(target, value);
		}
	}

	/// <summary>
	/// Creates a new instance of the given type and decodes its content from the buffer.
	/// </summary>
	/// <param name="type">The type of object to decode.</param>
	/// <param name="buffer">The buffer to decode from.</param>
	/// <returns>The decoded object instance.</returns>
	private static object? DecodeObject(Type type, EByteArray buffer)
	{
		IEncodable instance = (IEncodable)Activator.CreateInstance(type)!;

		// Handle case where the object is null.
		if (instance.IsOptional && (bool)BoolCodec.Instance.Decode(buffer))
		{
			return null;
		}

		var fields = type.GetFields(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(f => f.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(f => f.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var field in fields)
		{
			object? value = DecodeValue(field.FieldType, buffer);
			field.SetValue(instance, value);
		}

		var properties = type.GetProperties(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			)
			.Where(p => p.CanWrite && p.GetCustomAttribute<EncodeAttribute>() != null)
			.OrderBy(p => p.GetCustomAttribute<EncodeAttribute>()?.Order);

		foreach (var prop in properties)
		{
			object? value = DecodeValue(prop.PropertyType, buffer);
			prop.SetValue(instance, value);
		}

		return instance;
	}

	/// <summary>
	/// Decodes a single value of a specified type from the buffer.
	/// </summary>
	/// <param name="type">The expected type of the value.</param>
	/// <param name="buffer">The buffer to read from.</param>
	/// <returns>The decoded value.</returns>
	private static object? DecodeValue(Type type, EByteArray buffer)
	{
		Type actualType = Nullable.GetUnderlyingType(type) ?? type;
		// Case 1: Primitive codec
		if (codecs.TryGetValue(type, out var codec))
		{
			return codec.Decode(buffer);
		}
		// Case 2: Enum
		else if (actualType.IsEnum)
		{
			int enumInt = (int)IntCodec.Instance.Decode(buffer)!;
			return Enum.ToObject(actualType, enumInt);
		}
		// Case 3: Array
		else if (type.IsArray && type.GetElementType() is Type elementType)
		{
			bool shorten = false;
			codecs.TryGetValue(elementType, out var elementCodec);

			if (typeof(IEncodable).IsAssignableFrom(elementType))
			{
				PropertyInfo? isArrayOptionalProp = elementType.GetProperty(
					"IsArrayOptional",
					BindingFlags.Public | BindingFlags.Static
				);
				if (isArrayOptionalProp != null && isArrayOptionalProp.PropertyType == typeof(bool))
				{
					shorten = (bool)isArrayOptionalProp.GetValue(null)!;
				}
			}

			if (!(elementCodec is null))
			{
				shorten = elementCodec.IsArrayOptional;
			}

			if (shorten && (bool)BoolCodec.Instance.Decode(buffer)!)
				return null;

			int length = (int)IntCodec.Instance.Decode(buffer)!;
			Array result = Array.CreateInstance(elementType, length);

			if (!(elementCodec is null))
			{
				for (int i = 0; i < length; i++)
				{
					object? item = elementCodec.Decode(buffer);
					result.SetValue(item, i);
				}
			}
			else
			{
				for (int i = 0; i < length; i++)
				{
					object? item = DecodeValue(elementType, buffer);
					result.SetValue(item, i);
				}
			}

			return result;
		}
		// Case 4: Complex type
		else
		{
			return DecodeObject(type, buffer);
		}
	}
}
