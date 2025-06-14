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
        public static int Id { get; } = -322235316;
        public override string Description => "Reason why player was kicked from battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "reason",
        };
    }
}
