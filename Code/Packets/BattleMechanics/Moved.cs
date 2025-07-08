using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Receives movement data of a player from the server.
/// </summary>
public class Moved : AbstractPacket
{
    public static int Id { get; } = -64696933;
    public override string Description => "Receives movement data of a player from the server.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        MoveCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "movement"
    };
}