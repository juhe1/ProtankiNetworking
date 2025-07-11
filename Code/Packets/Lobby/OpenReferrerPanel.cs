using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for opening the referrer panel (data, inviteLink, banner, inviteMessage).
/// </summary>
public class OpenReferrerPanel : AbstractPacket
{
    public const int ID_CONST = 1587315905;
    public override int Id => ID_CONST;
    public override string Description => "Open referrer panel (data, inviteLink, banner, inviteMessage)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(ReferrerIncomeDataCodec.Instance, false), // data
        StringCodec.Instance, // inviteLink
        StringCodec.Instance, // banner
        StringCodec.Instance  // inviteMessage
    };
    public override string[] Attributes => new[]
    {
        "data",
        "inviteLink",
        "banner",
        "inviteMessage"
    };
} 