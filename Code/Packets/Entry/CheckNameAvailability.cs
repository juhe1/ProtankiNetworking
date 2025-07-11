using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Check if a name is up for registration
/// </summary>
public class CheckNameAvailability : AbstractPacket
{
    public const int IdStatic = 1083705823;
    public override int Id => IdStatic;
    public override string Description => "Check if a name is up for registration";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}