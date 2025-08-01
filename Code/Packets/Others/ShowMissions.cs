using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Show the list of missions currently available to the player
/// </summary>
public class ShowMissions : AbstractPacket
{
    public const int ID_CONST = 809822533;
    public override int Id => ID_CONST;
    public override string Description => "Show the list of missions currently available to the player";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(MissionCodec.Instance, false),
        MissionStreakCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "missions",
        "weeklyStreakInfo"
    };
}