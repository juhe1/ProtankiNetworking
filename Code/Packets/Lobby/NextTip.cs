using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for requesting or sending the next tip (no attributes).
/// </summary>
public class NextTip : AbstractPacket
{
    public const int ID_CONST = -1376947245;
    public override int Id => ID_CONST;
    public override string Description => "Next tip (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
}