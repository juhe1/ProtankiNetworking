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
        public static int Id { get; } = 504016996;
        public override string Description => "A player has left a DM battle, the observer being outside the battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "username",
        };
    }
}
