using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Load Purchasable Items
    /// </summary>
    public class LoadPurchasableItems : AbstractPacket
    {
        public static int Id { get; } = -300370823;
        public override string Description => "Load Purchasable Items";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
        };
    }
}
