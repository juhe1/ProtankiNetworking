using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Respawn Delay Packet
/// </summary>
public class RespawnDelay : AbstractPacket
{
    public const int ID_CONST = -173682854;
    public override int Id => ID_CONST;
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