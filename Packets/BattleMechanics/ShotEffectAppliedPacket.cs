using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Shot Effect Applied
    /// </summary>
    public class ShotEffectAppliedPacket : AbstractPacket
    {
        public static new int Id { get; } = 546849203;
        public static new string Description { get; } = "Shot Effect Applied";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(Vector3DCodec) };
        public static new string[] Attributes { get; } = new[] { "shooter", "hitPoint" };
    }
} 