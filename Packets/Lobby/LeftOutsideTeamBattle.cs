using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Remove this player from the friends count in team status
    /// </summary>
    public class LeftOutsideTeamBattle : AbstractPacket
    {
        public static new int Id { get; } = 1447204641;
        public static new string Description { get; } = "Remove this player from the friends count in team status";
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
