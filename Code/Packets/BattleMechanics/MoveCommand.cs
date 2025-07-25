using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Receives movement data of a player from the server.
/// </summary>
public class MoveCommand : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public MoveData? Movement { get; set; }

	[Encode(2)]
	public float TurretDirection { get; set; }

	public const int ID_CONST = 1516578027;
	public override int Id => ID_CONST;
	public override string Description => "Receives movement data of a player from the server.";
}
