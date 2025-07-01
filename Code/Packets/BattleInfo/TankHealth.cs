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
        public static int Id { get; } = -611961116;
        public override string Description => "Updates the health of a tank";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            FloatCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "health",
        };
    }
}
