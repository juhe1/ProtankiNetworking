using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Get the id of the last battle you selected
    /// </summary>
    public class LastBattleId : AbstractPacket
    {
        public static int Id { get; } = -602527073;
        public override string Description => "Get the id of the last battle you selected";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleId",
        };
    }
}
