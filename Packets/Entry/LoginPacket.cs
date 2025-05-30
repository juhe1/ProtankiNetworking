using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Login information sent by the client
    /// </summary>
    public class LoginPacket : AbstractPacket
    {
        public static new int Id { get; } = -739684591;
        public static new string Description { get; } = "Login information sent by the client";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "password", "rememberMe" };
    }
} 