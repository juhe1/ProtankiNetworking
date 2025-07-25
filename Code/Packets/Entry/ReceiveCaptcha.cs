using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Received a captcha image with its type
/// </summary>
public class ReceiveCaptcha : Packet
{
    [Encode(0)]
    public CaptchaLocation? Location { get; set; }

    [Encode(1)]
    public byte[]? Imagedata { get; set; }

    public const int ID_CONST = -1670408519;
    public override int Id => ID_CONST;
    public override string Description => "Received a captcha image with its type";


}