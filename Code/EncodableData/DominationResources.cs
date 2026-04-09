using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class DominationResources : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Resource? BigLetters { get; set; }

	[Encode(1)]
	public Resource? BlueCircle { get; set; }

	[Encode(2)]
	public Resource? BluePedestalTexture { get; set; }

	[Encode(3)]
	public Resource? BlueRay { get; set; }

	[Encode(4)]
	public Resource? BlueRayTip { get; set; }

	[Encode(5)]
	public Resource? NeutralCircle { get; set; }

	[Encode(6)]
	public Resource? NeutralPedestalTexture { get; set; }

	[Encode(7)]
	public Resource? Pedestal { get; set; }

	[Encode(8)]
	public Resource? RedCircle { get; set; }

	[Encode(9)]
	public Resource? RedPedestalTexture { get; set; }

	[Encode(10)]
	public Resource? RedRay { get; set; }

	[Encode(11)]
	public Resource? RedRayTip { get; set; }

}
