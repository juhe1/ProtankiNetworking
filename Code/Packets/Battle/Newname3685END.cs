using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class Newname3685END : Packet
{

	[Encode(0)]
	public byte Newname7931END { get; set; }

	public const int ID_CONST = 201628290;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
