namespace ProtankiNetworking.Packets.Flamethrower;

public class FlamethrowerStopOutPacket : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1300958299;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
