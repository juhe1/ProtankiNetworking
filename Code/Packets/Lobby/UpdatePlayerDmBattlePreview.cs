using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Updates a player's kills in a DM battle preview
/// </summary>
public class UpdatePlayerDmBattlePreview : AbstractPacket
{
    public const int IdStatic = -1263036614;
    public override int Id => IdStatic;
    public override string Description => "Updates a player's kills in a DM battle preview";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID",
        "username",
        "kills"
    };
}