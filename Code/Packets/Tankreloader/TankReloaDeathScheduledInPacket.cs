using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tankreloader;

public class TankReloaDeathScheduledInPacket : Packet
{

	[Encode(0)]
	public int SuicideDelayMS { get; set; }

	public const int ID_CONST = -911983090;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
