using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Said name is available for registration
/// </summary>
public class NameAvailable : AbstractPacket
{
    public const int ID_CONST = -706679202;
    public override int Id => ID_CONST;
    public override string Description => "Said name is available for registration";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}