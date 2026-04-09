using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class ShellHit : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int ShotId { get; set; }

	[Encode(1)]
	public ShellState?[]? States { get; set; }

	[Encode(2)]
	public TargetPosition?[]? Targets { get; set; }

}
