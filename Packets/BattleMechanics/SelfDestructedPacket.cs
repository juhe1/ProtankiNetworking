using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Information about a self destructed tank
    /// </summary>
    public class SelfDestructedPacket : AbstractPacket
    {
        public static new int Id { get; } = 162656882;
        public static new string Description { get; } = "Information about a self destructed tank";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "respDelay" };
    }
} 