using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// A player has left a DM battle, the observer being outside the battle
    /// </summary>
    public class LeftOutsideDmBattle : AbstractPacket
    {
        public static new int Id { get; } = 504016996;
        public static new string Description { get; } = "A player has left a DM battle, the observer being outside the battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "username",
        };
    }
}
