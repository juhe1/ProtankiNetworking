using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Receives movement data of a player from the server.
/// </summary>
public class Moved : AbstractPacket
{
    public const int ID_CONST = -64696933;
    public override int Id => ID_CONST;
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