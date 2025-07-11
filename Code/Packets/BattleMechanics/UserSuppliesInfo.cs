using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Bonus Box Resources
/// </summary>
public class UserSuppliesInfo : AbstractPacket
{
    public const int ID_CONST = -137249251;
    public override int Id => ID_CONST;
    public override string Description => "Load Bonus Box Resources";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}