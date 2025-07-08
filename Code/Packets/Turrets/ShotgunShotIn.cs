using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending shotgun shot information.
    /// </summary>
    public class ShotgunShotIn : AbstractPacket
    {
        public static int Id { get; } = 471157826;
        public override string Description => "Send shotgun shot information";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // weapon id
            Vector3DCodec.Instance, // hit position
            new VectorCodec(TargetHitCodec.Instance, false), // hits
        };
        public override string[] Attributes => new string[]
        {
            "weaponId",
            "hitPosition",
            "hits",
        };
    }
} 