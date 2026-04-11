using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class Newname3687END : Packet
{

	[Encode(0)]
	public int[]? Newname758END { get; set; }

	public const int ID_CONST = -745598420;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
