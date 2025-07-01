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
        public static int Id { get; } = -911983090;
        public override string Description => "Suicide delay packet";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "suicideDelayMS",
        };
    }
}
