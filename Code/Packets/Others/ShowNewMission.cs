using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Show the new mission that was previously changed
/// </summary>
public class ShowNewMission : AbstractPacket
{
    public const int ID_CONST = -1266665816;
    public override int Id => ID_CONST;
    public override string Description => "Show the new mission that was previously changed";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        MissionCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "missionId",
        "mission"
    };
}