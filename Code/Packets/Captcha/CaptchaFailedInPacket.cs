using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Captcha;

public class CaptchaFailedInPacket : Packet
{

	[Encode(0)]
	public CaptchaLocation? Location { get; set; }

	[Encode(1)]
	public byte[]? ImageData { get; set; }

	public const int ID_CONST = -373510957;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
