using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Sends your movement data to the server
    /// </summary>
    public class Move : AbstractPacket
    {
        public static new int Id { get; } = 329279865;
        public static new string Description { get; } = "Sends your movement data to the server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            ShortCodec.Instance,
            MoveCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "specificationID",
            "movement",
        };
    }
}
