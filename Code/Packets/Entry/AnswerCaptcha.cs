using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Answer the captcha
/// </summary>
public class AnswerCaptcha : Packet
{
    [Encode(0)]
    public CaptchaLocation? Location { get; set; }

    [Encode(1)]
    public string? Text { get; set; }

    public const int ID_CONST = 1271163230;
    public override int Id => ID_CONST;
    public override string Description => "Answer the captcha";


}