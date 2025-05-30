using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Information about all maps the client should load
    /// </summary>
    public class LoadMapInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = -838186985;
        public static new string Description { get; } = "Information about all maps the client should load";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
        public static new bool ShouldLog { get; } = false;
    }
} 