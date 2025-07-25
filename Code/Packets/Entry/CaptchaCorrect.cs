using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Captcha is correct
/// </summary>
public class CaptchaCorrect : Packet
{
	[Encode(0)]
	public CaptchaLocation? Location { get; set; }

	public const int ID_CONST = -819536476;
	public override int Id => ID_CONST;
	public override string Description => "Captcha is correct";
}
