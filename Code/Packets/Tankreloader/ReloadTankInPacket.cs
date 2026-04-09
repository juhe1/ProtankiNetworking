using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tankreloader;

public class ReloadTankInPacket : Packet
{

	[Encode(0)]
	public string? Tank { get; set; }

	public const int ID_CONST = -1767633906;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
