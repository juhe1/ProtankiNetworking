using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for unloading battle objects.
/// </summary>
public class UnloadBattleObjects : AbstractPacket
{
    public const int IdStatic = -985579124;
    public override int Id => IdStatic;
    public override string Description => "Unload battle objects";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
}