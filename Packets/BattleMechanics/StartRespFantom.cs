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
        public static new int Id { get; } = 875259457;
        public static new string Description { get; } = "Information about fantom status of a player";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            ShortCodec.Instance,
            ShortCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
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
