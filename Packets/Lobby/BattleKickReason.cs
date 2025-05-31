using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Reason why player was kicked from battle
    /// </summary>
    public class BattleKickReason : AbstractPacket
    {
        public static new int Id { get; } = -322235316;
        public static new string Description { get; } = "Reason why player was kicked from battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "reason",
        };
    }
}
