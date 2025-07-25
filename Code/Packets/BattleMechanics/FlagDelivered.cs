using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for flag delivery event, indicating the winning team and the deliverer tank ID.
/// </summary>
public class FlagDelivered : Packet
{
    [Encode(0)]
    public BattleTeam? WinnerTeam { get; set; }

    [Encode(1)]
    public string? DelivererTankId { get; set; }

    public const int ID_CONST = -1870108387;
    public override int Id => ID_CONST;
    public override string Description => "Flag delivered event (winning team and deliverer tank ID)";


}