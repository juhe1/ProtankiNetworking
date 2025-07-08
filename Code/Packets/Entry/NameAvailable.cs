using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Said name is available for registration
/// </summary>
public class NameAvailable : AbstractPacket
{
    public static int Id { get; } = -706679202;
    public override string Description => "Said name is available for registration";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}