

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Sets captcha hash keys
/// </summary>
public class SetCaptchaKeys : Packet
{
    [Encode(0)]
    public int[]? Keys { get; set; }

    public const int ID_CONST = 321971701;
    public override int Id => ID_CONST;
    public override string Description => "Sets captcha hash keys";


}