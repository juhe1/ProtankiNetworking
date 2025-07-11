using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to unload the lobby chat.
/// </summary>
public class UnloadLobbyChat : AbstractPacket
{
    public const int IdStatic = -920985123;
    public override int Id => IdStatic;
    public override string Description => "Unload the lobby chat";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}