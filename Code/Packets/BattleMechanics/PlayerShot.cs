using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player shot a shot.
/// </summary>
public class PlayerShot : AbstractPacket
{
    public const int IdStatic = -44282936;
    public override int Id => IdStatic;
    public override string Description => "Player shot a shot.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        ByteCodec.Instance,
        IntCodec.Instance,
        Vector3DCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "barrel",
        "shotId",
        "shotDirection"
    };
}