using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Captcha;

public class SetCaptchaKeysInPacket : Packet
{

	[Encode(0)]
	public CaptchaLocation?[]? Keys { get; set; }

	public const int ID_CONST = 321971701;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
