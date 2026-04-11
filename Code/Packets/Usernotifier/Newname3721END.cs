using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class Newname3721END : Packet
{

	[Encode(0)]
	public string? UserInfo { get; set; }

	public const int ID_CONST = -1353047954;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
