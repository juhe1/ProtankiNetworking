using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Send Respawn(fantom) Packet
/// </summary>
public class SendRespawn : AbstractPacket
{
    public const int IdStatic = -1378839846;
    public override int Id => IdStatic;
    public override string Description => "Send Respawn(fantom) Packet";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}