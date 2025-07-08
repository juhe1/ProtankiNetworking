using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Turret Control Packet
/// </summary>
public class TurretControl : AbstractPacket
{
    public static int Id { get; } = -1749108178;
    public override string Description => "Turret Control Packet";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        ShortCodec.Instance,
        ByteCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "specificationID",
        "control"
    };
}