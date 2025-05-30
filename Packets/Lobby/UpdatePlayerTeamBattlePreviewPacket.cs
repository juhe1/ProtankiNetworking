using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Updates a player's score in a team battle preview
    /// </summary>
    public class UpdatePlayerTeamBattlePreviewPacket : AbstractPacket
    {
        public static new int Id { get; } = -375282889;
        public static new string Description { get; } = "Updates a player's score in a team battle preview";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username", "score" };
        public static new bool ShouldLog { get; } = false;
    }
} 