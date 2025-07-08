using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player despawns while alive
/// </summary>
public class DespawnAlive : AbstractPacket
{
    public static int Id { get; } = 1719707347;
    public override string Description => "Player despawns while alive";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}