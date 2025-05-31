using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Sets the player's battle status to not in battle
    /// </summary>
    public class NotInBattleStatus : AbstractPacket
    {
        public static new int Id { get; } = 1941694508;
        public static new string Description { get; } = "Sets the player's battle status to not in battle";
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
