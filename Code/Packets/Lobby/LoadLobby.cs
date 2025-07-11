using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Load battle info
/// </summary>
public class LoadLobby : AbstractPacket
{
    public static int IdStatic { get; } = 1452181070;
    public override int Id => IdStatic;
    public override string Description => "Load battle info";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}