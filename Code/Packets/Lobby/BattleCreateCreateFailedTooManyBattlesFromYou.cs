using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for battle creation failed due to too many battles from the user (no attributes).
/// </summary>
public class BattleCreateCreateFailedTooManyBattlesFromYou : AbstractPacket
{
    public const int IdStatic = -614313838;
    public override int Id => IdStatic;
    public override string Description => "Battle create failed: too many battles from you (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 