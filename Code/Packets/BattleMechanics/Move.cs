using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends your movement data to the server
/// </summary>
public class Move : AbstractPacket
{
    public static int IdStatic { get; } = 329279865;
    public override int Id => IdStatic;
    public override string Description => "Sends your movement data to the server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        ShortCodec.Instance,
        MoveCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "specificationID",
        "movement"
    };
}