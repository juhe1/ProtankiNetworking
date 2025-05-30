using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Sent when a mine is placed.
    /// </summary>
    public class MinePlacePacket : AbstractPacket
    {
        public static new int Id { get; } = -624217047;
        public static new string Description { get; } = "Sent when a mine is placed.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "mineId" };
    }
} 