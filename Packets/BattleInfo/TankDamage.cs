using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Damage dealt to a tank
    /// </summary>
    public class TankDamage : AbstractPacket
    {
        public static new int Id { get; } = -1165230470;
        public static new string Description { get; } = "Damage dealt to a tank";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(TankDamageCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "damages",
        };
    }
}
