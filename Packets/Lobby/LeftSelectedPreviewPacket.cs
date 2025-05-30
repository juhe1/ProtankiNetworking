using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// A player has left the selected battle, from the preview screen
    /// </summary>
    public class LeftSelectedPreviewPacket : AbstractPacket
    {
        public static new int Id { get; } = 1924874982;
        public static new string Description { get; } = "A player has left the selected battle, from the preview screen";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 