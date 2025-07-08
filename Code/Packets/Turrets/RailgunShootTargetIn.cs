using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Railgun shoot target event.
/// </summary>
public class RailgunShootTargetIn : AbstractPacket
{
    public static int Id { get; } = -369590613;
    public override string Description => "Send Railgun shoot target event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooterUserId
        Vector3DCodec.Instance, // staticHitPoint
        new VectorCodec(StringCodec.Instance, true), // targetUserIds
        new VectorCodec(Vector3DCodec.Instance, true) // targetHitPoints
    };

    public override string[] Attributes => new[]
    {
        "shooterUserId",
        "staticHitPoint",
        "targetUserIds",
        "targetHitPoints"
    };
}