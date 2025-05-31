using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Updates the health of a tank
    /// </summary>
    public class TankHealth : AbstractPacket
    {
        public static new int Id { get; } = -611961116;
        public static new string Description { get; } = "Updates the health of a tank";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            FloatCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "health",
        };
    }
}
