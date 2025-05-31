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
        public static new int Id { get; } = -2124388778;
        public static new string Description { get; } = "Syncs turret data to the client";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
