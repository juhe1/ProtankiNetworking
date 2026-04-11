using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Settings;

public class CloseSettingsInPacket : Packet
{

	public const int ID_CONST = -1302674105;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
