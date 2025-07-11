using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Twins fire dummy event.
/// </summary>
public class TwinsFireDummyIn : AbstractPacket
{
    public const int ID_CONST = -328554480;
    public override int Id => ID_CONST;
    public override string Description => "Send Twins fire dummy event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooter
        ByteCodec.Instance // fireType
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "fireType"
    };
}