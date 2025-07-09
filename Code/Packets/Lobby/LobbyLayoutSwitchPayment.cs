using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for switching lobby layout payment (no attributes).
/// </summary>
public class LobbyLayoutSwitchPayment : AbstractPacket
{
    public static int IdStatic { get; } = 1153801756;
    public override int Id => IdStatic;
    public override string Description => "Lobby layout switch payment (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 