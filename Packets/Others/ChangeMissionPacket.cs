using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Change mission
    /// </summary>
    public class ChangeMissionPacket : AbstractPacket
    {
        public static new int Id { get; } = 1642608662;
        public static new string Description { get; } = "Change mission";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "missionId" };
    }
} 