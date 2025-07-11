using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Said name is unavailable for registration with a list of alternative suggested usernames
/// </summary>
public class NameUnavailable : AbstractPacket
{
    public static int IdStatic { get; } = 442888643;

    public override string Description =>
        "Said name is unavailable for registration with a list of alternative suggested usernames";

    public override BaseCodec[] CodecObjects =>
        new BaseCodec[] { new VectorCodec(StringCodec.Instance, true) };

    public override string[] Attributes => new[] { "usernames" };
}

