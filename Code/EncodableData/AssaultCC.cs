using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class AssaultCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ClientAssaultFlag?[]? BlueFlags { get; set; }

	[Encode(1)]
	public Resource? FlagPedestalModel { get; set; }

	[Encode(2)]
	public Resource? FlagSprite { get; set; }

	[Encode(3)]
	public Resource? PointCircleTexture { get; set; }

	[Encode(4)]
	public Resource? PointPedestalModel { get; set; }

	[Encode(5)]
	public AssaultBase?[]? RedBases { get; set; }

	[Encode(6)]
	public AssaultSoundFX? Sounds { get; set; }

}
