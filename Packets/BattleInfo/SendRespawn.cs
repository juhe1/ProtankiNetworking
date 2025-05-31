using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Send Respawn(fantom) Packet
    /// </summary>
    public class SendRespawn : AbstractPacket
    {
        public static new int Id { get; } = -1378839846;
        public static new string Description { get; } = "Send Respawn(fantom) Packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
