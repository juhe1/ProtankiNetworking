using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class ShowNewPresent : Packet
{

	public const int ID_CONST = -1154479430;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
