using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class LoadControlPointsCCInPacket : Packet
{

	[Encode(0)]
	public int SoundNotification { get; set; }

	public const int ID_CONST = -1337059439;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
