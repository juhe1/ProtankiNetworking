using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Server sends options for Login
    /// </summary>
    public class LoginReadyPacket : AbstractPacket
    {
        public static new int Id { get; } = -1277343167;
        public static new string Description { get; } = "Server sends options for Login";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(BoolCodec), typeof(IntCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "bgResourceID", "requireEmail", "maxPWLen", "minPWLen" };
    }
} 