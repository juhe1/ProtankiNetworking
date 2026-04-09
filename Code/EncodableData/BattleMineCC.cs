using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleMineCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Resource? ActivateSound { get; set; }

	[Encode(1)]
	public int ActivateTimeMsec { get; set; }

	[Encode(2)]
	public BattleMine?[]? BattleMines { get; set; }

	[Encode(3)]
	public Resource? BlueMineTexture { get; set; }

	[Encode(4)]
	public Resource? DeactivateSound { get; set; }

	[Encode(5)]
	public Resource? EnemyMineTexture { get; set; }

	[Encode(6)]
	public Resource? ExplosionMarkTexture { get; set; }

	[Encode(7)]
	public Resource? ExplosionSound { get; set; }

	[Encode(8)]
	public float FarVisibilityRadius { get; set; }

	[Encode(9)]
	public Resource? FriendlyMineTexture { get; set; }

	[Encode(10)]
	public Resource? IdleExplosionTexture { get; set; }

	[Encode(11)]
	public float ImpactForce { get; set; }

	[Encode(12)]
	public Resource? MainExplosionTexture { get; set; }

	[Encode(13)]
	public float MinDistanceFromBase { get; set; }

	[Encode(14)]
	public Resource? Model3ds { get; set; }

	[Encode(15)]
	public float NearVisibilityRadius { get; set; }

	[Encode(16)]
	public float Radius { get; set; }

	[Encode(17)]
	public Resource? RedMineTexture { get; set; }

}
