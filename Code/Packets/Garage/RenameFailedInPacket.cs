using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class RenameFailedInPacket : Packet
{

	public const int ID_CONST = -471022967;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
