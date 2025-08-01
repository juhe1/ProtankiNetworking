using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for mine explosion event (mineId, targetId).
/// </summary>
public class ExplodeMine : AbstractPacket
{
    public const int ID_CONST = 1387974401;
    public override int Id => ID_CONST;
    public override string Description => "Explode mine (mineId, targetId)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // mineId
        StringCodec.Instance // targetId
    };

    public override string[] Attributes => new[]
    {
        "mineId",
        "targetId"
    };
}