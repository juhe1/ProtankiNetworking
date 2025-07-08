using ProtankiNetworking.Codec;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    public enum LayoutState
    {
        MATCHMAKING = 0,
        BATTLE_SELECT = 1,
        GARAGE = 2,
        BATTLE = 3,
        RELOAD_SPACE = 4,
        CLAN = 5
    }

    /// <summary>
    /// Codec for LayoutState enum, encoding/decoding as int.
    /// </summary>
    public class LayoutStateCodec : BaseCodec
    {
        public static LayoutStateCodec Instance { get; } = new LayoutStateCodec();

        public override object? Decode(EByteArray buffer)
        {
            int value = (int)IntCodec.Instance.Decode(buffer);
            return value switch
            {
                0 => LayoutState.MATCHMAKING,
                1 => LayoutState.BATTLE_SELECT,
                2 => LayoutState.GARAGE,
                3 => LayoutState.BATTLE,
                4 => LayoutState.RELOAD_SPACE,
                5 => LayoutState.CLAN,
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
} 