using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Battle user control packet
    /// </summary>
    public class BattleUserControlPacket : AbstractPacket
    {
        public static new int Id { get; } = -301298508;
        public static new string Description { get; } = "Battle user control packet";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(ByteCodec) };
        public static new string[] Attributes { get; } = new[] { "tankiId", "control" };
    }
} 