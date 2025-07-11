using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Accept mission
/// </summary>
public class AcceptMission : AbstractPacket
{
    public const int ID_CONST = -867767128;
    public override int Id => ID_CONST;
    public override string Description => "Accept mission";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "missionId"
    };
}