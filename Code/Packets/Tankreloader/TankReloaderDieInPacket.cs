using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tankreloader;

public class TankReloaderDieInPacket : Packet
{

	[Encode(0)]
	public string? Tank { get; set; }

	[Encode(1)]
	public int Delay { get; set; }

	public const int ID_CONST = -173682854;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
