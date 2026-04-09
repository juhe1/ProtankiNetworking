using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class StatusProbablyCheaterChangedInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public bool Suspicious { get; set; }

	public const int ID_CONST = 446781737;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
