using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Updates a team's score in the battle preview
    /// </summary>
    public class UpdateTeamBattlePreviewPacket : AbstractPacket
    {
        public static new int Id { get; } = 1428217189;
        public static new string Description { get; } = "Updates a team's score in the battle preview";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "team", "score" };
        public static new bool ShouldLog { get; } = false;
    }
} 