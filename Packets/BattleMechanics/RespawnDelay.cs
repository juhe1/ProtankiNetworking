using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Respawn Delay Packet
    /// </summary>
    public class RespawnDelay : AbstractPacket
    {
        public static new int Id { get; } = -173682854;
        public static new string Description { get; } = "Respawn Delay Packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "tank",
            "respawnDelay",
        };
    }
}
