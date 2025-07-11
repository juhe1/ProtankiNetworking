using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends a self destruct request to the server
/// </summary>
public class SelfDestruct : AbstractPacket
{
    public const int ID_CONST = 988664577;
    public override int Id => ID_CONST;
    public override string Description => "Sends a self destruct request to the server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}