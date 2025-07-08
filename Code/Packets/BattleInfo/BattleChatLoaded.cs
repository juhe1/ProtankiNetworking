using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet to indicate that the battle chat has loaded.
    /// </summary>
    public class BattleChatLoaded : AbstractPacket
    {
        public static int Id { get; } = -643105296;
        public override string Description => "Indicates that the battle chat has loaded";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {
        };
    }
} 