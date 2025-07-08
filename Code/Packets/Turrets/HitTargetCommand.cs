using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for hitting a target: time, shotId, target, targetPosition, hitPointWorld. Used in Twins and Ricochet.
    /// </summary>
    public class HitTargetCommand : AbstractPacket
    {
        public static int Id { get; } = -1723353904;
        public override string Description => "Hit target command (time, shotId, target, targetPosition, hitPointWorld). Used in Twins and Ricochet.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            IntCodec.Instance, // shotId
            StringCodec.Instance, // target
            Vector3DCodec.Instance, // targetPosition
            Vector3DCodec.Instance, // hitPointWorld
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "shotId",
            "target",
            "targetPosition",
            "hitPointWorld",
        };
    }
} 