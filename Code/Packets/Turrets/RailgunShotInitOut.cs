using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Sends server details about a railgun shot that has just started to release
/// </summary>
public class RailgunShotInitOut : AbstractPacket
{
    public static int Id { get; } = -1759063234;

    public override string Description =>
        "Sends server details about a railgun shot that has just started to release";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}