using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Respawn Delay Packet
/// </summary>
public class RespawnDelay : AbstractPacket
{
    public static int IdStatic { get; } = -173682854;
    public override int Id => IdStatic;
    public override string Description => "Respawn Delay Packet";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "tank",
        "respawnDelay"
    };
}