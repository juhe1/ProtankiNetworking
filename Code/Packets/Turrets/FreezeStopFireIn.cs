using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Freeze stop fire event.
/// </summary>
public class FreezeStopFireIn : AbstractPacket
{
    public const int ID_CONST = 979099084;
    public override int Id => ID_CONST;
    public override string Description => "Freeze stop fire event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooterId
    };

    public override string[] Attributes => new[]
    {
        "shooterId"
    };
}