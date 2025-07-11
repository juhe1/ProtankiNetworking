using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login failed
/// </summary>
public class LoginFailed : AbstractPacket
{
    public const int ID_CONST = 103812952;
    public override int Id => ID_CONST;
    public override string Description => "Login failed";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}