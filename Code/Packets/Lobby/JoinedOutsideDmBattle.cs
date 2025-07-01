using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins a global DM battle, outside from the observer's perspective.
    /// </summary>
    public class JoinedOutsideDmBattle : AbstractPacket
    {
        public static int Id { get; } = -2133657895;
        public override string Description => "Sent when a player joins a global DM battle, outside from the observer's perspective.";
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
