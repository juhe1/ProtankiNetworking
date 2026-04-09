using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftLaserAimAtTankOutPacket : Packet
{

	[Encode(0)]
	public string? TargetTank { get; set; }

	[Encode(1)]
	public Vector3D? LocalSpotPosition { get; set; }

	public const int ID_CONST = -1517837003;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
