using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Said name is unavailable for registration with a list of alternative suggested usernames
    /// </summary>
    public class NameUnavailable : AbstractPacket
    {
        public static new int Id { get; } = 442888643;
        public static new string Description { get; } = "Said name is unavailable for registration with a list of alternative suggested usernames";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            VectorStringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "usernames",
        };
    }
}
