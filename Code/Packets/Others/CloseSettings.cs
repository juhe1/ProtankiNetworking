using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Close settings modal
/// </summary>
public class CloseSettings : AbstractPacket
{
    public const int ID_CONST = -731115522;
    public override int Id => ID_CONST;
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