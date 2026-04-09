using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class ClientPointData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int Id { get; set; }

	[Encode(1)]
	public string? Name { get; set; }

	[Encode(2)]
	public float Score { get; set; }

	[Encode(3)]
	public float ScoreChangeRate { get; set; }

	[Encode(4)]
	public ControlPointState? State { get; set; }

	[Encode(5)]
	public string?[]? TankIds { get; set; }

}
