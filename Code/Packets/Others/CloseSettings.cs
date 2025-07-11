using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Close settings modal
/// </summary>
public class CloseSettings : AbstractPacket
{
    public static int IdStatic { get; } = -731115522;
    public override int Id => IdStatic;
    public override string Description => "Close settings modal";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "close_state"
    };
}