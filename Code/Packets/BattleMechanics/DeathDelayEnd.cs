using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Respawn delay ends and player can start respawning
/// </summary>
public class DeathDelayEnd : AbstractPacket
{
    public const int IdStatic = 268832557;
    public override int Id => IdStatic;
    public override string Description => "Respawn delay ends and player can start respawning";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}