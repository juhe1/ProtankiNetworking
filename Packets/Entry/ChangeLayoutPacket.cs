using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Changes client layout/mode
    /// </summary>
    public class ChangeLayoutPacket : AbstractPacket
    {
        public static new int Id { get; } = 1118835050;
        public static new string Description { get; } = "Changes client layout/mode";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "layout" };
    }
} 