using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Receives movement data of a player from the server.
/// </summary>
public class MoveCommand : AbstractPacket
{
    public const int IdStatic = 1516578027;
    public override int Id => IdStatic;
    public override string Description => "Receives movement data of a player from the server.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        MoveCodec.Instance,
        FloatCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "movement",
        "turretDirection"
    };
}