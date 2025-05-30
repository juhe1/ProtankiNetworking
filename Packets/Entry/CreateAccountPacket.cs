using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Create new account
    /// </summary>
    public class CreateAccountPacket : AbstractPacket
    {
        public static new int Id { get; } = 427083290;
        public static new string Description { get; } = "Create new account";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "password", "rememberMe" };
    }
} 