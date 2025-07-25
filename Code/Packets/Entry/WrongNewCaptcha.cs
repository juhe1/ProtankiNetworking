using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     The captcha was incorrect, a new one is sent
/// </summary>
public class WrongNewCaptcha : Packet
{
    [Encode(0)]
    public CaptchaLocation? Location { get; set; }

    [Encode(1)]
    public byte[]? Imagedata { get; set; }

    public const int ID_CONST = -373510957;
    public override int Id => ID_CONST;
    public override string Description => "The captcha was incorrect, a new one is sent";


}