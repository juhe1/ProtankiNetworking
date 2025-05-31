using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Suicide delay packet
    /// </summary>
    public class SuicideDelay : AbstractPacket
    {
        public static new int Id { get; } = -911983090;
        public static new string Description { get; } = "Suicide delay packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "suicideDelayMS",
        };
    }
}
