using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login successful
/// </summary>
public class LoginSuccess : AbstractPacket
{
    public const int IdStatic = -1923286328;
    public override int Id => IdStatic;
    public override string Description => "Login successful";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}