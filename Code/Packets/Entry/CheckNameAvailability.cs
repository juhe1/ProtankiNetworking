using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Check if a name is up for registration
    /// </summary>
    public class CheckNameAvailability : AbstractPacket
    {
        public static int Id { get; } = 1083705823;
        public override string Description => "Check if a name is up for registration";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
        };
    }
}
