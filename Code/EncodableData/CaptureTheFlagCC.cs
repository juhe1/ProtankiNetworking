using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class CaptureTheFlagCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ClientFlag? BlueFlag { get; set; }

	[Encode(1)]
	public Resource? BlueFlagSprite { get; set; }

	[Encode(2)]
	public Resource? BluePedestalModel { get; set; }

	[Encode(3)]
	public ClientFlag? RedFlag { get; set; }

	[Encode(4)]
	public Resource? RedFlagSprite { get; set; }

	[Encode(5)]
	public Resource? RedPedestalModel { get; set; }

	[Encode(6)]
	public CaptureTheFlagSoundFX? Sounds { get; set; }

}
