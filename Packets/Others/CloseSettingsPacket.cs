using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Close settings modal
    /// </summary>
    public class CloseSettingsPacket : AbstractPacket
    {
        public static new int Id { get; } = -731115522;
        public static new string Description { get; } = "Close settings modal";
        public static new Type[] CodecTypes { get; } = new[] { typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "close_state" };
    }
} 