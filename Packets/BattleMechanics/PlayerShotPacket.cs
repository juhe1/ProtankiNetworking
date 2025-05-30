using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Player shot a shot.
    /// </summary>
    public class PlayerShotPacket : AbstractPacket
    {
        public static new int Id { get; } = -44282936;
        public static new string Description { get; } = "Player shot a shot.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(ByteCodec), typeof(IntCodec), typeof(Vector3DCodec) };
        public static new string[] Attributes { get; } = new[] { "shooter", "barrel", "shotId", "shotDirection" };
    }
} 