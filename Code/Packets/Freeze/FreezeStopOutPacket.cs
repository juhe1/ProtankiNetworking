using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Freeze;

public class FreezeStopOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1654947652;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
