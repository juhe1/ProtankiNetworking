using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Settings;

public class LoadSettingsOutPacket : Packet
{

	public const int ID_CONST = 850220815;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
