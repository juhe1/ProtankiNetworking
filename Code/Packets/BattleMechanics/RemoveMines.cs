using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for removing mines by owner (ownerId).
    /// </summary>
    public class RemoveMines : AbstractPacket
    {
        public static int Id { get; } = -1200619383;
        public override string Description => "Remove mines (ownerId)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // ownerId
        };
        public override string[] Attributes => new string[]
        {
            "ownerId",
        };
    }
} 