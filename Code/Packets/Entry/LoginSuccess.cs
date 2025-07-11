using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login successful
/// </summary>
public class LoginSuccess : AbstractPacket
{
    public const int ID_CONST = -1923286328;
    public override int Id => ID_CONST;
    public override string Description => "Login successful";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}