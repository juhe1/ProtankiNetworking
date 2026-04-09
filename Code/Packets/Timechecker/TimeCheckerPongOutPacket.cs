using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Timechecker;

public class TimeCheckerPongOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ServerSessionTime { get; set; }

	public const int ID_CONST = 2074243318;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
