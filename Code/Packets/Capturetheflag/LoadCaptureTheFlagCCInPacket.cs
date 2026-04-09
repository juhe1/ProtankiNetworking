using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class LoadCaptureTheFlagCCInPacket : Packet
{

	[Encode(0)]
	public CaptureTheFlagCC? Cc { get; set; }

	public const int ID_CONST = 789790814;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
