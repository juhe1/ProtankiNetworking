using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to unload the garage space.
/// </summary>
public class UnloadGarageSpace : AbstractPacket
{
    public const int ID_CONST = 1211186637;
    public override int Id => ID_CONST;
    public override string Description => "Unload the garage space";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}