using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class NotInBattleStatusInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 1941694508;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
