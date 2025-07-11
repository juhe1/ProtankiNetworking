using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Updates a player's score in a team battle preview
/// </summary>
public class UpdatePlayerTeamBattlePreview : AbstractPacket
{
    public const int IdStatic = -375282889;
    public override int Id => IdStatic;
    public override string Description => "Updates a player's score in a team battle preview";

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
        "score"
    };
}