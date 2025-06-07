using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// When we stop using Freeze
    /// </summary>
    public class FreezeEndOut : AbstractPacket
    {
        public static int Id { get; } = -1654947652;
        public override string Description => "When we stop using Freeze";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
        };
    }
}
