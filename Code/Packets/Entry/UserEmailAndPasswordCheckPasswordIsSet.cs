using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for checking if user email and password is set (no attributes).
/// </summary>
public class UserEmailAndPasswordCheckPasswordIsSet : AbstractPacket
{
    public const int ID_CONST = -1507635228;
    public override int Id => ID_CONST;
    public override string Description => "User email and password check password is set (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 