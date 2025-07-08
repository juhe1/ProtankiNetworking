using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Freeze stop fire event.
    /// </summary>
    public class FreezeStopFireIn : AbstractPacket
    {
        public static int Id { get; } = 979099084;
        public override string Description => "Freeze stop fire event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooterId
        };
        public override string[] Attributes => new string[]
        {
            "shooterId",
        };
    }
} 