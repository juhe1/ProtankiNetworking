using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Leaves battle to a layout (0 = Lobby, 1 = Garage)
    /// </summary>
    public class LeaveBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 377959142;
        public static new string Description { get; } = "Leaves battle to a layout (0 = Lobby, 1 = Garage)";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "layout" };
    }
} 