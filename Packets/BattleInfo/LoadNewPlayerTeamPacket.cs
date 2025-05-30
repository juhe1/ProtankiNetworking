using System;
using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Factory;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// A new player has joined the team battle
    /// </summary>
    public class LoadNewPlayerTeamPacket : AbstractPacket
    {
        public static new int Id { get; } = 2040021062;
        public static new string Description { get; } = "A new player has joined the team battle";
        public static new Type[] CodecTypes { get; } = new[] 
        { 
            typeof(StringCodec),
            typeof(VectorBattleUserCodec),
            typeof(IntCodec)
        };
        public static new string[] Attributes { get; } = new[] { "username", "userinfos", "team" };
    }
} 