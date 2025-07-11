using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     User Changed Equipment
/// </summary>
public class UserChangedEquipment : AbstractPacket
{
    public const int IdStatic = -1767633906;
    public override int Id => IdStatic;
    public override string Description => "User Changed Equipment";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "tank"
    };
}