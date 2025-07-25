using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Receives movement data of a player from the server.
/// </summary>
public class Moved : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public MoveData? Movement { get; set; }

	public const int ID_CONST = -64696933;
	public override int Id => ID_CONST;
	public override string Description => "Receives movement data of a player from the server.";
}
