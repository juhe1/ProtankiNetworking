using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Shaft laser hide out (no attributes).
    /// </summary>
    public class ShaftLaserHideOut : AbstractPacket
    {
        public static int Id { get; } = 843751647;
        public override string Description => "Shaft laser hide out (no attributes)";
        public override BaseCodec[] CodecObjects => new BaseCodec[] { };
        public override string[] Attributes => new string[] { };
    }
} 