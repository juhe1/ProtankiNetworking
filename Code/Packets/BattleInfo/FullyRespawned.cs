using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet sent when the player has fully respawned
    /// </summary>
    public class FullyRespawned : AbstractPacket
    {
        public static int Id { get; } = 1868573511;
        public override string Description => "Packet sent when the player has fully respawned";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
        };
    }
}
