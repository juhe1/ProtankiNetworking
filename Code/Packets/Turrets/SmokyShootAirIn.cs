using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Smoky shoot air event.
/// </summary>
public class SmokyShootAirIn : AbstractPacket
{
    public const int ID_CONST = -1032328347;
    public override int Id => ID_CONST;
    public override string Description => "Send Smoky shoot air event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };

    public override string[] Attributes => new[]
    {
        "userId"
    };
}