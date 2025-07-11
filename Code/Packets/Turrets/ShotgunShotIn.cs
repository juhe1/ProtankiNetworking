using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending shotgun shot information.
/// </summary>
public class ShotgunShotIn : AbstractPacket
{
    public const int ID_CONST = 471157826;
    public override int Id => ID_CONST;
    public override string Description => "Send shotgun shot information";

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