using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Captcha;

public class RequestCaptchaOutPacket : Packet
{

	[Encode(0)]
	public CaptchaLocation? Location { get; set; }

	public const int ID_CONST = -349828108;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
