using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class RoundFinishInPacket : Packet
{

	[Encode(0)]
	public UserReward?[]? Reward { get; set; }

	[Encode(1)]
	public int TimeToRestart { get; set; }

	public const int ID_CONST = 560336625;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
