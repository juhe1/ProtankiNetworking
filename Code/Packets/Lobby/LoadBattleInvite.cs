using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for BattleInviteCC, containing a sound notification resource.
/// </summary>
public class LoadBattleInvite : AbstractPacket
{
    public static int IdStatic { get; } = 834877801;
    public override int Id => IdStatic;
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