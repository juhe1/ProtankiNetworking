using System;
using System.Collections.Generic;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Battle User Stats
    /// </summary>
    public class UserStatsPacket : AbstractPacket
    {
        public static new int Id { get; } = 1061006142;
        public static new string Description { get; } = "Battle User Stats";
        public static new Type[] CodecTypes { get; } = new[] 
        { 
            typeof(VectorBattleUserStatsCodec)
        };
        public static new string[] Attributes { get; } = new[] { "usersStat" };
    }
} 