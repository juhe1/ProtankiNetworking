using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class RenameSuccessfulInPacket : Packet
{

	[Encode(0)]
	public string? NewName { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1968445033;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
