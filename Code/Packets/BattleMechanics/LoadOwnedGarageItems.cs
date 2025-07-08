using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Owned Garage Items
/// </summary>
public class LoadOwnedGarageItems : AbstractPacket
{
    public static int Id { get; } = -255516505;
    public override string Description => "Load Owned Garage Items";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}