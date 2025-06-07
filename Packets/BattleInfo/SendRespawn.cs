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
        public static int Id { get; } = -1378839846;
        public override string Description => "Send Respawn(fantom) Packet";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
