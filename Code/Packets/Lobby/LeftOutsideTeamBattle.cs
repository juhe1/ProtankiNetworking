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
        public static int Id { get; } = 1447204641;
        public override string Description => "Remove this player from the friends count in team status";
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
