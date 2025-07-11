using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for requesting or sending the next tip (no attributes).
/// </summary>
public class NextTip : AbstractPacket
{
    public static int IdStatic { get; } = -1376947245;
    public override int Id => IdStatic;
    public override string Description => "Next tip (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
}