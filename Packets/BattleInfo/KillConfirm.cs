using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// A tank has been killed
    /// </summary>
    public class KillConfirm : AbstractPacket
    {
        public static new int Id { get; } = -42520728;
        public static new string Description { get; } = "A tank has been killed";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "target",
            "killer",
            "respDelay",
        };
    }
}
