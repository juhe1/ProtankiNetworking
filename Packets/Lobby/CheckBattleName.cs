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
        public static new int Id { get; } = 566652736;
        public static new string Description { get; } = "Censors invalid battle names";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleName",
        };
    }
}
