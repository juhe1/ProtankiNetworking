using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Censors invalid battle names
    /// </summary>
    public class CheckBattleName : AbstractPacket
    {
        public static int Id { get; } = 566652736;
        public override string Description => "Censors invalid battle names";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleName",
        };
    }
}
