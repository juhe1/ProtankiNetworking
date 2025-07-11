using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Client end the Fantom period to fully spawn
/// </summary>
public class EndRespFantom : AbstractPacket
{
    public const int ID_CONST = 1178028365;
    public override int Id => ID_CONST;
    public override string Description => "Client end the Fantom period to fully spawn";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}