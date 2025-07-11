using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Change By
/// </summary>
public class ChangeBy : AbstractPacket
{
    public const int IdStatic = -593513288;
    public override int Id => IdStatic;
    public override string Description => "Change By";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "changeBy"
    };
}