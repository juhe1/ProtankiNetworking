using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Suicide delay packet
    /// </summary>
    public class SuicideDelayPacket : AbstractPacket
    {
        public static new int Id { get; } = -911983090;
        public static new string Description { get; } = "Suicide delay packet";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "suicideDelayMS" };
    }
} 