using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for BattleInviteCC, containing a sound notification resource.
/// </summary>
public class LoadBattleInvite : AbstractPacket
{
    public const int ID_CONST = 834877801;
    public override int Id => ID_CONST;
    public override string Description => "BattleInviteCC packet with sound notification";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // soundNotification
    };

    public override string[] Attributes => new[]
    {
        "soundNotification"
    };
}