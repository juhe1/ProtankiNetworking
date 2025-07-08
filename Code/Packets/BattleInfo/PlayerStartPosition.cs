using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Player Start Position
/// </summary>
public class PlayerStartPosition : AbstractPacket
{
    public static int IdStatic { get; } = -157204477;
    public override int Id => IdStatic;
    public override string Description => "Player Start Position";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        Vector3DCodec.Instance,
        Vector3DCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "position",
        "orientation"
    };
}