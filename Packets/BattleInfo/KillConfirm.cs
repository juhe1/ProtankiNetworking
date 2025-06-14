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
        public static int Id { get; } = -42520728;
        public override string Description => "A tank has been killed";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "target",
            "killer",
            "respDelay",
        };
    }
}
