using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Syncs turret data to the client
    /// </summary>
    public class SyncTurretData : AbstractPacket
    {
        public static int Id { get; } = -2124388778;
        public override string Description => "Syncs turret data to the client";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
        };
    }
}
