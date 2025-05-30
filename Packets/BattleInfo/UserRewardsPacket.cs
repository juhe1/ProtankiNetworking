using System;
using System.Collections.Generic;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Battle User Rewards
    /// </summary>
    public class UserRewardsPacket : AbstractPacket
    {
        public static new int Id { get; } = 560336625;
        public static new string Description { get; } = "Battle User Rewards";
        public static new Type[] CodecTypes { get; } = new[] 
        { 
            typeof(VectorBattleUserRewardsCodec),
            typeof(IntCodec)
        };
        public static new string[] Attributes { get; } = new[] { "reward", "timeToRestart" };
    }
} 