using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet to indicate that the battle TDM object has been loaded (post event).
/// </summary>
public class BattleTDMObjectLoadedPost : AbstractPacket
{
    public static int Id { get; } = 183561709;
    public override string Description => "Indicates that the battle TDM object has been loaded (post event)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}