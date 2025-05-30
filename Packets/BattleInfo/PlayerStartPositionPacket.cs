using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Player Start Position
    /// </summary>
    public class PlayerStartPositionPacket : AbstractPacket
    {
        public static new int Id { get; } = -157204477;
        public static new string Description { get; } = "Player Start Position";
        public static new Type[] CodecTypes { get; } = new[] { typeof(Vector3DCodec), typeof(Vector3DCodec) };
        public static new string[] Attributes { get; } = new[] { "position", "orientation" };
    }
} 