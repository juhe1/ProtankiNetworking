using ProtankiNetworking.Codec;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets;

/// <summary>
///     Abstract class for packets. This class is used to define the structure of packets that are sent and received by the
///     server.
///     WARNING: This class is not an abstract class.
///     You can still create instances of this class, such as when no children class exists, but it is not recommended.
/// </summary>
public class AbstractPacket
{
    /// <summary>
    ///     Length of the packet header in bytes
    /// </summary>
    public const int HEADER_LEN = 8;

    /// <summary>
    ///     Packet identifier
    /// </summary>
    public virtual int Id {get; set;} = 0;

    /// <summary>
    ///     Description of the packet
    /// </summary>
    public virtual string Description => "Unknown packet";

    /// <summary>
    ///     List of codecs used to encode/decode packet data
    /// </summary>
    public virtual ICodec[] CodecObjects => Array.Empty<ICodec>();

    /// <summary>
    ///     List of attribute names for the packet
    /// </summary>
    public virtual string[] Attributes => Array.Empty<string>();

    /// <summary>
    ///     Whether the packet should be logged
    /// </summary>
    public virtual bool ShouldLog => true;

    /// <summary>
    ///     The original raw packet data
    /// </summary>
    public byte[] RawData { get; set; } = Array.Empty<byte>();

    /// <summary>
    ///     The decrypted packet data (without headers)
    /// </summary>
    public byte[] DecryptedData { get; set; } = Array.Empty<byte>();

    /// <summary>
    ///     List of decoded objects
    /// </summary>
    public List<object?> Objects { get; } = new();

    /// <summary>
    ///     Dictionary containing the packet data
    /// </summary>
    public Dictionary<string, object?> ObjectByAttributeName { get; } = new();

    /// <summary>
    ///     Decodes the binary data into individual objects
    /// </summary>
    /// <param name="packetData">The binary data to decode</param>
    /// <returns>Dictionary containing the decoded packet data</returns>
    public Dictionary<string, object?> Unwrap(EByteArray packetData)
    {
        Objects.Clear();

        foreach (var codec in CodecObjects)
            Objects.Add(codec.Decode(packetData));

        return Implement();
    }

    /// <summary>
    ///     Encodes all the objects into binary data for the packet payload
    /// </summary>
    /// <param name="protection">Optional protection for encrypting the packet data</param>
    /// <returns>Encoded packet data</returns>
    public EByteArray Wrap(Protection? protection = null)
    {
        EByteArray packetData;
        var dataLen = HEADER_LEN;

        if (this is UnknownPacket)
        {
            throw new Exception("Cannot wrap UnknownPacket");
        }
        else
        {
            packetData = new EByteArray();
            // Encode the objects according to the codecs
            for (int i = 0; i < CodecObjects.Length; i++)
                dataLen += CodecObjects[i].Encode(Objects[i], packetData);
        }

        var encryptedData = protection?.Encrypt(packetData.ToArray()) ?? packetData.ToArray();
        var result = new EByteArray();
        result.WriteInt(dataLen);
        result.WriteInt(Id);
        result.Write(new EByteArray(encryptedData));
        return result;
    }

    /// <summary>
    ///     Implements the packet object based on the attribute key list and the decoded object list
    /// </summary>
    /// <returns>Dictionary containing the implemented packet data</returns>
    protected Dictionary<string, object?> Implement()
    {
        ObjectByAttributeName.Clear();
        for (int i = 0; i < Objects.Count; i++)
            ObjectByAttributeName[Attributes[i]] = Objects[i];

        return ObjectByAttributeName;
    }

    /// <summary>
    ///     Returns a string representation of the packet for logging purposes
    /// </summary>
    /// <param name="direction">True for incoming packets, false for outgoing</param>
    /// <returns>String representation of the packet</returns>
    public string LogRepr(bool direction)
    {
        string packetName =
            GetType().Name == nameof(AbstractPacket)
                ? $"Unknown Packet - ID: {Id}"
                : GetType().Name;

        return $"<{(direction ? "IN" : "OUT")}> ({packetName}){(ShouldLog ? "" : " - NoDisp")} | Data: {ObjectByAttributeName}";
    }
}
