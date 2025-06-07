using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Receives movement data of a player from the server.
    /// </summary>
    public class MoveCommand : AbstractPacket
    {
        public static int Id { get; } = 1516578027;
        public override string Description => "Receives movement data of a player from the server.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            MoveCodec.Instance,
            FloatCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "movement",
            "turretDirection",
        };
    }
}
