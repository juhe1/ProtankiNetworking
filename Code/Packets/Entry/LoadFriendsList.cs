using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Loads the player's friend lists
/// </summary>
public class LoadFriendsList : AbstractPacket
{
    public const int IdStatic = 1422563374;
    public override int Id => IdStatic;
    public override string Description => "Loads the player's friend lists";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}