using System;
using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// A new player has joined the battle
    /// </summary>
    public class LoadNewPlayerDMPacket : AbstractPacket
    {
        public static new int Id { get; } = 862913394;
        public static new string Description { get; } = "A new player has joined the battle";
        public static new Type[] CodecTypes { get; } = new[] 
        { 
            typeof(StringCodec),
            typeof(VectorBattleUserCodec)
        };
        public static new string[] Attributes { get; } = new[] { "username", "userinfos" };
    }
} 