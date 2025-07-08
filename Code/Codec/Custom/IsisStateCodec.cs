using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom;

public enum IsisState
{
    OFF = 0,
    IDLE = 1,
    HEALING = 2,
    DAMAGING = 3
}

/// <summary>
///     Codec for IsisState enum, encoding/decoding as int.
/// </summary>
public class IsisStateCodec : BaseCodec
{
    public static IsisStateCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => IsisState.OFF,
            1 => IsisState.IDLE,
            2 => IsisState.HEALING,
            3 => IsisState.DAMAGING,
            _ => throw new System.Exception($"Unknown IsisState value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(IsisState)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
}