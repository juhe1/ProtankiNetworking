using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class DropFlagOutPacket : Packet
{

	public const int ID_CONST = -1832611824;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
