using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom;

public enum ChatModeratorLevel
{
    NONE = 0,
    COMMUNITY_MANAGER = 1,
    ADMINISTRATOR = 2,
    MODERATOR = 3,
    CANDIDATE = 4
}

/// <summary>
///     Codec for ChatModeratorLevel enum, encoding/decoding as int.
/// </summary>
public class ChatModeratorLevelCodec : BaseCodec
{
    public static ChatModeratorLevelCodec Instance { get; } = new();

    public override object? Decode(EByteArray buffer)
    {
        int value = (int)IntCodec.Instance.Decode(buffer);
        return value switch
        {
            0 => ChatModeratorLevel.NONE,
            1 => ChatModeratorLevel.COMMUNITY_MANAGER,
            2 => ChatModeratorLevel.ADMINISTRATOR,
            3 => ChatModeratorLevel.MODERATOR,
            4 => ChatModeratorLevel.CANDIDATE,
            _ => throw new System.Exception($"Unknown ChatModeratorLevel value: {value}")
        };
    }

    public override int Encode(object? value, EByteArray buffer)
    {
        if (value == null)
            throw new System.ArgumentNullException(nameof(value));
        int intValue = (int)(ChatModeratorLevel)value;
        return IntCodec.Instance.Encode(intValue, buffer);
    }
}