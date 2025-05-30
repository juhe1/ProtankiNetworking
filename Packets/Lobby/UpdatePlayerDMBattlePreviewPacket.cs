using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Updates a player's kills in a DM battle preview
    /// </summary>
    public class UpdatePlayerDMBattlePreviewPacket : AbstractPacket
    {
        public static new int Id { get; } = -1263036614;
        public static new string Description { get; } = "Updates a player's kills in a DM battle preview";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username", "kills" };
        public static new bool ShouldLog { get; } = false;
    }
} 