using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player Ranked Up
/// </summary>
public class RankUp : AbstractPacket
{
    public const int ID_CONST = 1262947513;
    public override int Id => ID_CONST;
    public override string Description => "Player Ranked Up";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "rank"
    };
}