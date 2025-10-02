using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class Mission : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool FreeChange { get; set; }

	[Encode(1)]
	public string? Description { get; set; }

	[Encode(2)]
	public int Threshold { get; set; }

	[Encode(3)]
	public Resource? Image { get; set; }

	[Encode(4)]
	public MissionReward?[]? Rewards { get; set; }

	[Encode(5)]
	public int Progress { get; set; }

	[Encode(6)]
	public int MissionID { get; set; }

	[Encode(7)]
	public int ChangeCost { get; set; }
}
