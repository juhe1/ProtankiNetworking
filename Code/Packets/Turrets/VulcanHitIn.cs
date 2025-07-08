using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Vulcan hit information.
/// </summary>
public class VulcanHitIn : AbstractPacket
{
    public static int Id { get; } = -891286317;
    public override string Description => "Send Vulcan hit information";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // weapon id
        Vector3DCodec.Instance, // hit position
        new VectorCodec(TargetHitCodec.Instance, false) // hits
    };

    public override string[] Attributes => new[]
    {
        "weaponId",
        "hitPosition",
        "hits"
    };
}