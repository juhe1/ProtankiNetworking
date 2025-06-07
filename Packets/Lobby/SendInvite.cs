using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Send a battle invite to a player
    /// </summary>
    public class SendInvite : AbstractPacket
    {
        public static int Id { get; } = -864265623;
        public override string Description => "Send a battle invite to a player";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "battleID",
        };
    }
}
