using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for mine explosion event (mineId, targetId).
    /// </summary>
    public class ExplodeMine : AbstractPacket
    {
        public static int Id { get; } = 1387974401;
        public override string Description => "Explode mine (mineId, targetId)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // mineId
            StringCodec.Instance, // targetId
        };
        public override string[] Attributes => new string[]
        {
            "mineId",
            "targetId",
        };
    }
} 