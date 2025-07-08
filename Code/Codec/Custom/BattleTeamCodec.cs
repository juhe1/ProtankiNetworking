using ProtankiNetworking.Codec;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    public enum BattleTeam
    {
        RED = 0,
        BLUE = 1,
        NONE = 2
    }

    /// <summary>
    /// Codec for BattleTeam enum, encoding/decoding as int.
    /// </summary>
    public class BattleTeamCodec : BaseCodec
    {
        public static BattleTeamCodec Instance { get; } = new BattleTeamCodec();

        public override object? Decode(EByteArray buffer)
        {
            int value = (int)IntCodec.Instance.Decode(buffer);
            return value switch
            {
                0 => BattleTeam.RED,
                1 => BattleTeam.BLUE,
                2 => BattleTeam.NONE,
                _ => throw new System.Exception($"Unknown BattleTeam value: {value}")
            };
        }

        public override int Encode(object? value, EByteArray buffer)
        {
            if (value == null)
                throw new System.ArgumentNullException(nameof(value));
            int intValue = (int)(BattleTeam)value;
            return IntCodec.Instance.Encode(intValue, buffer);
        }
    }
} 