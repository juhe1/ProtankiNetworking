using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Updates a player's kills in a DM battle preview
    /// </summary>
    public class UpdatePlayerDmBattlePreview : AbstractPacket
    {
        public static int Id { get; } = -1263036614;
        public override string Description => "Updates a player's kills in a DM battle preview";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "username",
            "kills",
        };
    }
}
