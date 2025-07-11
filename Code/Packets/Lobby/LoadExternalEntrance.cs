using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads external entrance data, containing a vector of social network entrance params.
/// </summary>
public class LoadExternalEntrance : AbstractPacket
{
    public const int ID_CONST = -1715719586;
    public override int Id => ID_CONST;
    public override string Description => "Load external entrance data.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(SocialNetworkEntranceParamsCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "socialNetworkEntranceParams"
    };
}