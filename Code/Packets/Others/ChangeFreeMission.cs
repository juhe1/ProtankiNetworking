using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change free mission
/// </summary>
public class ChangeFreeMission : AbstractPacket
{
    public static int IdStatic { get; } = 326032325;
    public override int Id => IdStatic;
    public override string Description => "Change free mission";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "missionId"
    };
}