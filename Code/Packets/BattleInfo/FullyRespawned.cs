using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet sent when the player has fully respawned
/// </summary>
public class FullyRespawned : AbstractPacket
{
    public const int ID_CONST = 1868573511;
    public override int Id => ID_CONST;
    public override string Description => "Packet sent when the player has fully respawned";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}