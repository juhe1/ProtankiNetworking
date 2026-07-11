using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.UserProperties;

public class UpdateScoreInPacket : Packet
{
	
	[Encode(0)]
	public int Score { get; set; }

	public const int ID_CONST = 2116086491;
	public override int Id => ID_CONST;
	public override string Description => "Updates the user score shown in the panel.";
}
