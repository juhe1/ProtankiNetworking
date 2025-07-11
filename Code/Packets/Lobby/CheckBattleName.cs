using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Censors invalid battle names
/// </summary>
public class CheckBattleName : AbstractPacket
{
    public const int ID_CONST = 566652736;
    public override int Id => ID_CONST;
    public override string Description => "Censors invalid battle names";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleName"
    };
}