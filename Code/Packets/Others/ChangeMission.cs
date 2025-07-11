using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change mission
/// </summary>
public class ChangeMission : AbstractPacket
{
    public const int IdStatic = 1642608662;
    public override int Id => IdStatic;
    public override string Description => "Change mission";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "missionId"
    };
}