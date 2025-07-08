using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Leaves battle to a layout (0 = Lobby, 1 = Garage)
/// </summary>
public class LeaveBattle : AbstractPacket
{
    public static int Id { get; } = 377959142;
    public override string Description => "Leaves battle to a layout (0 = Lobby, 1 = Garage)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "layout"
    };
}