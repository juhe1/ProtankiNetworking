using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends a self destruct request to the server
/// </summary>
public class SelfDestruct : AbstractPacket
{
    public static int Id { get; } = 988664577;
    public override string Description => "Sends a self destruct request to the server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}