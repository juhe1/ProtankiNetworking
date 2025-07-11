using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Leaves battle to a layout (0 = Lobby, 1 = Garage)
/// </summary>
public class LeaveBattle : AbstractPacket
{
    public const int ID_CONST = 377959142;
    public override int Id => ID_CONST;
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