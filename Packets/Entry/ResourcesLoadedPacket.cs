using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Client callsback after finishes resource loading (NOT IMPLEMENTED)
    /// </summary>
    public class ResourcesLoadedPacket : AbstractPacket
    {
        public static new int Id { get; } = -82304134;
        public static new string Description { get; } = "Client callsback after finishes resource loading (NOT IMPLEMENTED)";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "callbackId" };
    }
} 