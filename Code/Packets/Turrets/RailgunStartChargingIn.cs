using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Railgun start charging event.
    /// </summary>
    public class RailgunStartChargingIn : AbstractPacket
    {
        public static int Id { get; } = 346830254;
        public override string Description => "Send Railgun start charging event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // userId
        };
        public override string[] Attributes => new string[]
        {
            "userId",
        };
    }
} 