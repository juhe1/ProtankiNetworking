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
        public static int Id { get; } = -173682854;
        public override string Description => "Respawn Delay Packet";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "tank",
            "respawnDelay",
        };
    }
}
