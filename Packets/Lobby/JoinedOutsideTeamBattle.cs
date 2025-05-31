using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins a global Team battle, outside from the observer's perspective.
    /// </summary>
    public class JoinedOutsideTeamBattle : AbstractPacket
    {
        public static new int Id { get; } = -169305322;
        public static new string Description { get; } = "Sent when a player joins a global Team battle, outside from the observer's perspective.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "username",
            "team",
        };
    }
}
