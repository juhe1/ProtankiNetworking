using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet for loading referrer panel configuration (ReferrerPanelCC).
    /// </summary>
    public class LoadReferrerPanelCC : AbstractPacket
    {
        public static int Id { get; } = 832270655;
        public override string Description => "Load referrer panel configuration (ReferrerPanelCC)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // hash
            StringCodec.Instance, // host
        };
        public override string[] Attributes => new string[]
        {
            "hash",
            "host",
        };
    }
} 