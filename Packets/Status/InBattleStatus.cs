using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Sets the battle status of the player to the battle ID
    /// </summary>
    public class InBattleStatus : AbstractPacket
    {
        public static int Id { get; } = -1895446889;
        public override string Description => "Sets the battle status of the player to the battle ID";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BattleNotifierCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleNotifier",
        };
    }
}
