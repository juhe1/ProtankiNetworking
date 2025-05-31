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
        public static new int Id { get; } = -44282936;
        public static new string Description { get; } = "Player shot a shot.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            ByteCodec.Instance,
            IntCodec.Instance,
            Vector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "shooter",
            "barrel",
            "shotId",
            "shotDirection",
        };
    }
}
