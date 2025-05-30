using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Show the new mission that was previously changed
    /// </summary>
    public class ShowNewMissionPacket : AbstractPacket
    {
        public static new int Id { get; } = -1266665816;
        public static new string Description { get; } = "Show the new mission that was previously changed";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(MissionCodec) };
        public static new string[] Attributes { get; } = new[] { "missionId", "mission" };
    }
} 