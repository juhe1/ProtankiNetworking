using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for notifying that user email and password is set (no attributes).
/// </summary>
public class UserEmailAndPasswordNotifyPasswordIsSet : AbstractPacket
{
    public static int IdStatic { get; } = 600420685;
    public override int Id => IdStatic;
    public override string Description => "User email and password notify password is set (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 