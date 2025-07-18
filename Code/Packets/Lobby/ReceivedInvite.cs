using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Accepts a player's battle invite
/// </summary>
public class ReceivedInvite : AbstractPacket
{
    public static int IdStatic { get; } = 810713262;
    public override int Id => IdStatic;
    public override string Description => "Accepts a player's battle invite";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}