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
        public static new int Id { get; } = 1868573511;
        public static new string Description { get; } = "Packet sent when the player has fully respawned";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
        };
    }
}
