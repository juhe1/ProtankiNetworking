using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class CaptureTheFlagSoundFX : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Resource? FlagDropSound { get; set; }

	[Encode(1)]
	public Resource? FlagReturnSound { get; set; }

	[Encode(2)]
	public Resource? FlagTakeSound { get; set; }

	[Encode(3)]
	public Resource? WinSound { get; set; }
}
