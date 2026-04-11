using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class UnsubscribeOutPacket : Packet
{

	[Encode(0)]
	public string?[]? Newname8536END { get; set; }

	public const int ID_CONST = -2040152224;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
