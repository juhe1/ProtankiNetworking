using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Load Map Lights
    /// </summary>
    public class LoadMapLights : AbstractPacket
    {
        public static new int Id { get; } = -152638117;
        public static new string Description { get; } = "Load Map Lights";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
