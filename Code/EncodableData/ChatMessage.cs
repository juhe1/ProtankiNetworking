using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class ChatMessage : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public UserStatus? AuthorStatus { get; set; }

	[Encode(1)]
	public bool SystemMessage { get; set; }

	[Encode(2)]
	public UserStatus? TargetStatus { get; set; }

	[Encode(3)]
	public string? Message { get; set; }

	[Encode(4)]
	public bool Warning { get; set; }
}
