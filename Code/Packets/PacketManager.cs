using System.Reflection;

namespace ProtankiNetworking.Packets;

/// <summary>
///     Manages packet types and their creation
/// </summary>
public static class PacketManager
{
	private static readonly Dictionary<int, Type> _packetTypesById = new Dictionary<int, Type>();
	private static readonly Dictionary<string, Type> _packetTypesByName =
		new Dictionary<string, Type>();

	static PacketManager()
	{
		// Find all packet types in the ProtankiNetworking assembly
		var assembly = typeof(Packet).Assembly;
		var packetTypes = assembly
			.GetTypes()
			.Where(t => t.IsSubclassOf(typeof(Packet)) && !t.IsAbstract);

		foreach (var type in packetTypes)
		{
			try
			{
				// Create an instance of the packet (requires parameterless constructor)
				var instance = Activator.CreateInstance(type) as Packet;

				if (instance == null)
					throw new Exception("Could not instantiate packet");

				int id = instance.Id; // Uses the overridden property in each packet type

				_packetTypesById[id] = type;
				_packetTypesByName[type.Name] = type;
			}
			catch (Exception ex)
			{
				// Log error but continue loading other packet types
				System.Diagnostics.Debug.WriteLine(
					$"Failed to load packet type {type.Name}: {ex.Message}"
				);
			}
		}
	}

	/// <summary>
	///     Gets a packet type by its ID
	/// </summary>
	/// <param name="id">The packet ID</param>
	/// <returns>The packet type, or null if not found</returns>
	public static Type? GetPacketById(int id)
	{
		return _packetTypesById.TryGetValue(id, out var type) ? type : null;
	}

	/// <summary>
	///     Gets a packet type by its name
	/// </summary>
	/// <param name="name">The packet name</param>
	/// <returns>The packet type, or null if not found</returns>
	public static Type? GetPacketByName(string name)
	{
		return _packetTypesByName.TryGetValue(name, out var type) ? type : null;
	}

	/// <summary>
	///     Creates a new packet instance by ID
	/// </summary>
	/// <param name="id">The packet ID</param>
	/// <returns>A new packet instance, or null if not found</returns>
	public static Packet? CreatePacketById(int id)
	{
		var type = GetPacketById(id);
		return type != null ? (Packet?)Activator.CreateInstance(type) : null;
	}

	/// <summary>
	///     Creates a new packet instance by name
	/// </summary>
	/// <param name="name">The packet name</param>
	/// <returns>A new packet instance, or null if not found</returns>
	public static Packet? CreatePacketByName(string name)
	{
		var type = GetPacketByName(name);
		return type != null ? (Packet?)Activator.CreateInstance(type) : null;
	}
}
