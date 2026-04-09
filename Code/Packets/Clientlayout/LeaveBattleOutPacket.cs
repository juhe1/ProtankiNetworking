using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Clientlayout;

public class LeaveBattleOutPacket : Packet
{

	[Encode(0)]
	public LayoutState? Layout { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
