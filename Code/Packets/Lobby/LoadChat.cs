using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading chat configuration.
/// </summary>
public class LoadChat : AbstractPacket
{
    public static int IdStatic { get; } = 178154988;
    public override int Id => IdStatic;
    public override string Description => "Load chat configuration";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance, // admin
        BoolCodec.Instance, // antifloodEnabled
        IntCodec.Instance, // bufferSize
        BoolCodec.Instance, // chatEnabled
        ChatModeratorLevelCodec.Instance, // chatModeratorLevel
        new VectorCodec(StringCodec.Instance, false), // linksWhiteList
        IntCodec.Instance, // minChar
        IntCodec.Instance, // minWord
        StringCodec.Instance, // selfName
        BoolCodec.Instance, // showLinks
        BoolCodec.Instance // typingSpeedAntifloodEnabled
    };

    public override string[] Attributes => new[]
    {
        "admin",
        "antifloodEnabled",
        "bufferSize",
        "chatEnabled",
        "chatModeratorLevel",
        "linksWhiteList",
        "minChar",
        "minWord",
        "selfName",
        "showLinks",
        "typingSpeedAntifloodEnabled"
    };
}