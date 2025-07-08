using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Vulcan stop fire event.
    /// </summary>
    public class VulcanStopFireIn : AbstractPacket
    {
        public static int Id { get; } = 133452238;
        public override string Description => "Vulcan stop fire event";
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