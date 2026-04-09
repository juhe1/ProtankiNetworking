using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Settings;

public class CloseSettingsOutPacket : Packet
{

	[Encode(0)]
	public bool CloseState { get; set; }

	public const int ID_CONST = -731115522;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
