using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads all current battles
/// </summary>
public class LoadAllBattles : AbstractPacket
{
    public const int ID_CONST = 552006706;
    public override int Id => ID_CONST;
    public override string Description => "Loads all current battles";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battlesJson"
    };
}