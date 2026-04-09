using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Settings;

public class OpenSettingsInPacket : Packet
{

	[Encode(0)]
	public bool NotificationEnabled { get; set; }

	public const int ID_CONST = 1447082276;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
