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
        public static new int Id { get; } = -1263036614;
        public static new string Description { get; } = "Updates a player's kills in a DM battle preview";
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
            "kills",
        };
    }
}
