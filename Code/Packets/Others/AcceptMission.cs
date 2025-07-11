using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Accept mission
/// </summary>
public class AcceptMission : AbstractPacket
{
    public static int IdStatic { get; } = -867767128;
    public override int Id => IdStatic;
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