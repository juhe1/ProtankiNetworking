using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for switching lobby layout payment (no attributes).
/// </summary>
public class LobbyLayoutSwitchPayment : AbstractPacket
{
    public const int ID_CONST = 1153801756;
    public override int Id => ID_CONST;
    public override string Description => "Lobby layout switch payment (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 