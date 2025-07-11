using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading the social network panel (passwordCreated, socialNetworkParams)
/// </summary>
public class LoadSocialNetworkPanelCC : AbstractPacket
{
    public const int IdStatic = -583564465;
    public override int Id => IdStatic;
    public override string Description => "Load social network panel (passwordCreated, socialNetworkParams)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance, // passwordCreated
        new VectorCodec(SocialNetworkPanelParamsCodec.Instance) // socialNetworkParams
    };
    public override string[] Attributes => new[]
    {
        "passwordCreated",
        "socialNetworkParams"
    };
} 