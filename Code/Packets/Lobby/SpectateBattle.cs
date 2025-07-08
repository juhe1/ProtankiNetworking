using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client requests to spectate the selected battle
/// </summary>
public class SpectateBattle : AbstractPacket
{
    public static int IdStatic { get; } = -1315002220;
    public override int Id => IdStatic;
    public override string Description => "Client requests to spectate the selected battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}