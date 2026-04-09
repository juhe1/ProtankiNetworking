using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Init;

public class SetClientLangOutPacket : Packet
{

	[Encode(0)]
	public string? Lang { get; set; }

	public const int ID_CONST = -1864333717;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
