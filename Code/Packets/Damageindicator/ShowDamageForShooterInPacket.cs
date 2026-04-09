using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Damageindicator;

public class ShowDamageForShooterInPacket : Packet
{

	[Encode(0)]
	public TargetTankDamage?[]? Damages { get; set; }

	public const int ID_CONST = -1165230470;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
