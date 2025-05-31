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
        public static new int Id { get; } = -1895446889;
        public static new string Description { get; } = "Sets the battle status of the player to the battle ID";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BattleNotifierCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleNotifier",
        };
    }
}
