using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Sets client language
    /// </summary>
    public class SetClientLangPacket : AbstractPacket
    {
        public static new int Id { get; } = -1864333717;
        public static new string Description { get; } = "Sets client language";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "lang" };
    }
} 