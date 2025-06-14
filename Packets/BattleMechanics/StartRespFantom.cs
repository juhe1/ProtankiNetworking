using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Information about fantom status of a player
    /// </summary>
    public class StartRespFantom : AbstractPacket
    {
        public static int Id { get; } = 875259457;
        public override string Description => "Information about fantom status of a player";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            ShortCodec.Instance,
            ShortCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "team",
            "position",
            "orientation",
            "health",
            "incarnationID",
        };
    }
}
