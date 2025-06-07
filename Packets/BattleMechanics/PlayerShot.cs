using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Player shot a shot.
    /// </summary>
    public class PlayerShot : AbstractPacket
    {
        public static int Id { get; } = -44282936;
        public override string Description => "Player shot a shot.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            ByteCodec.Instance,
            IntCodec.Instance,
            Vector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
            "barrel",
            "shotId",
            "shotDirection",
        };
    }
}
