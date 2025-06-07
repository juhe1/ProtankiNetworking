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
        public static int Id { get; } = 329279865;
        public override string Description => "Sends your movement data to the server";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            ShortCodec.Instance,
            MoveCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "specificationID",
            "movement",
        };
    }
}
