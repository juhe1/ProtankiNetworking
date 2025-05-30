using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Server tells us what resources to load
    /// </summary>
    public class LoadResourcesPacket : AbstractPacket
    {
        public static new int Id { get; } = -1797047325;
        public static new string Description { get; } = "Server tells us what resources to load";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "json", "callbackID" };
        public static new bool ShouldLog { get; } = false;
    }
} 