using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shotgun;

public class ShotgunTryDummyShootOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? ShootDirection { get; set; }

	public const int ID_CONST = 2128281231;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
