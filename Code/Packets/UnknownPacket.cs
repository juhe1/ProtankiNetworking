namespace ProtankiNetworking.Packets;

/// <summary>
///     Represents a packet with an unknown type
/// </summary>
public class UnknownPacket : AbstractPacket
{
    public UnknownPacket() { }

    /// <summary>
    ///     The ID of the unknown packet
    /// </summary>
    public int PacketId => Id;
}

