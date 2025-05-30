using System;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Show the list of missions currently available to the player
    /// </summary>
    public class ShowMissionsPacket : AbstractPacket
    {
        public static new int Id { get; } = 809822533;
        public static new string Description { get; } = "Show the list of missions currently available to the player";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorMissionCodec), typeof(MissionStreakCodec) };
        public static new string[] Attributes { get; } = new[] { "missions", "weeklyStreakInfo" };
    }
} 