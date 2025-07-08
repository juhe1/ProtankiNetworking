using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom;

public enum ControlPointState
{
    RED = 0,
    BLUE = 1,
    NEUTRAL = 2
}

/// <summary>
///     Codec for ControlPointState enum, encoding/decoding as int.
/// </summary>
public class ControlPointStateCodec : BaseCodec
{
    public static ControlPointStateCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => ControlPointState.RED,
            1 => ControlPointState.BLUE,
            2 => ControlPointState.NEUTRAL,
            _ => throw new System.Exception($"Unknown ControlPointState value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(ControlPointState)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
}