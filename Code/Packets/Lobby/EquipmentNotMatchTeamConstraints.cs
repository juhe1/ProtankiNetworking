using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to show a warning that the player is trying to join a team battle with wrong equipment.
/// </summary>
public class EquipmentNotMatchTeamConstraints : AbstractPacket
{
    public const int ID_CONST = -10847382;

    public override string Description =>
        "Warns that the player is trying to join a team battle with wrong equipment.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // battleTeamInfoObjectId
    };

    public override string[] Attributes => new[]
    {
        "battleTeamInfoObjectId"
    };
}