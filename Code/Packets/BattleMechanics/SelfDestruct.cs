using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends a self destruct request to the server
/// </summary>
public class SelfDestruct : AbstractPacket
{
    public const int IdStatic = 988664577;
    public override int Id => IdStatic;
    public override string Description => "Sends a self destruct request to the server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}