using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Receives movement data of a player from the server.
    /// </summary>
    public class Moved : AbstractPacket
    {
        public static new int Id { get; } = -64696933;
        public static new string Description { get; } = "Receives movement data of a player from the server.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            MoveCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "movement",
        };
    }
}
