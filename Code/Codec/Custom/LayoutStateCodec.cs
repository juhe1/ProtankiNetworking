using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom;

public enum LayoutState
{
    BATTLE_SELECT = 0,
    GARAGE = 1,
    PAYMENT = 2,
    BATTLE = 3,
    RELOAD_SPACE = 4
}

/// <summary>
///     Codec for LayoutState enum, encoding/decoding as int.
/// </summary>
public class LayoutStateCodec : BaseCodec
{
    public static LayoutStateCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => LayoutState.BATTLE_SELECT,
            1 => LayoutState.GARAGE,
            2 => LayoutState.PAYMENT,
            3 => LayoutState.BATTLE,
            4 => LayoutState.RELOAD_SPACE,
            _ => throw new System.Exception($"Unknown LayoutState value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(LayoutState)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
}
