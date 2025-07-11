using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Open Friends List
/// </summary>
public class OpenFriendsList : AbstractPacket
{
    public const int IdStatic = 1441234714;
    public override int Id => IdStatic;
    public override string Description => "Open Friends List";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}