using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Collect a crystal box
    /// </summary>
    public class CollectCryBox : AbstractPacket
    {
        public static int Id { get; } = -1047185003;
        public override string Description => "Collect a crystal box";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "bonusId",
        };
    }
}
