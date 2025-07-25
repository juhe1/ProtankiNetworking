using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Request a captcha
/// </summary>
public class RequestCaptcha : Packet
{
    [Encode(0)]
    public CaptchaLocation? Location { get; set; }

    public const int ID_CONST = -349828108;
    public override int Id => ID_CONST;
    public override string Description => "Request a captcha";


}