using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Attempts to sync ping information with the server
    /// </summary>
    public class BattlePingSync : AbstractPacket
    {
        public static int IdStatic { get; } = 2074243318;
        public override int Id => IdStatic;
    public override string Description => "Attempts to sync ping information with the server";

        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
        };

        public override string[] Attributes => new string[]
        {
            "clientTime",
            "serverSessionTime",
        };
    }
}