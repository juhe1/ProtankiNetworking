using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Locations of existing bonus boxes
    /// </summary>
    public class BonusBoxExistingLocations : AbstractPacket
    {
        public static int Id { get; } = 870278784;
        public override string Description => "Locations of existing bonus boxes";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
        };
    }
}
