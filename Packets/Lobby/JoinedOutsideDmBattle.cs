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
        public static new int Id { get; } = -2133657895;
        public static new string Description { get; } = "Sent when a player joins a global DM battle, outside from the observer's perspective.";
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
