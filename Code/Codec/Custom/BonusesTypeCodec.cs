using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

// not used

namespace ProtankiNetworking.Codec.Custom;

public enum BonusesType
{
    NITRO = 0,
    DAMAGE = 1,
    ARMOR = 2,
    HEALTH = 3,
    CRYSTAL = 4,
    GOLD = 5,
    SPECIAL = 6,
    MOON = 7,
    PUMPKIN = 8
}

/// <summary>
///     Codec for BonusesType enum, encoding/decoding as int.
/// </summary>
public class BonusesTypeCodec : BaseCodec
{
    public static BonusesTypeCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => BonusesType.NITRO,
            1 => BonusesType.DAMAGE,
            2 => BonusesType.ARMOR,
            3 => BonusesType.HEALTH,
            4 => BonusesType.CRYSTAL,
            5 => BonusesType.GOLD,
            6 => BonusesType.SPECIAL,
            7 => BonusesType.MOON,
            8 => BonusesType.PUMPKIN,
            _ => throw new System.Exception($"Unknown BonusesType value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(BonusesType)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
}