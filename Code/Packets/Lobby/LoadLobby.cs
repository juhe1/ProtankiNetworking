using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Load battle info
/// </summary>
public class LoadLobby : AbstractPacket
{
    public const int ID_CONST = 1452181070;
    public override int Id => ID_CONST;
    public override string Description => "Load battle info";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}