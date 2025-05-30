using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// email
    /// </summary>
    public class EmailPacket : AbstractPacket
    {
        public static new int Id { get; } = 613462801;
        public static new string Description { get; } = "email";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "email", "emailConfirmed" };
    }
} 