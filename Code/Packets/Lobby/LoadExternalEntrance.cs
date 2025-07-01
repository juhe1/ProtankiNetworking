using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Loads external entrance data, containing a vector of social network entrance params.
    /// </summary>
    public class LoadExternalEntrance : AbstractPacket
    {
        public static int Id { get; } = -1715719586;
        public override string Description => "Load external entrance data.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(SocialNetworkEntranceParamsCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "socialNetworkEntranceParams",
        };
    }
} 