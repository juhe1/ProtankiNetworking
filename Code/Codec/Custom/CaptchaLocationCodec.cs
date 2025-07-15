using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom;

public enum CaptchaLocation
{
    LOGIN_FORM = 0,
    REGISTER_FORM = 1,
    CLIENT_STARTUP = 2,
    RESTORE_PASSWORD_FORM = 3,
    EMAIL_CHANGE_HASH = 4,
    ACCOUNT_SETTINGS_FORM = 5
}

/// <summary>
///     Codec for CaptchaLocation enum, encoding/decoding as int.
/// </summary>
public class CaptchaLocationCodec : BaseCodec
{
    public static CaptchaLocationCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => CaptchaLocation.LOGIN_FORM,
            1 => CaptchaLocation.REGISTER_FORM,
            2 => CaptchaLocation.CLIENT_STARTUP,
            3 => CaptchaLocation.RESTORE_PASSWORD_FORM,
            4 => CaptchaLocation.EMAIL_CHANGE_HASH,
            5 => CaptchaLocation.ACCOUNT_SETTINGS_FORM,
            _ => throw new System.Exception($"Unknown CaptchaLocation value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(CaptchaLocation)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
} 