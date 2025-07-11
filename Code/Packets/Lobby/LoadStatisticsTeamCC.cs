using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading team statistics (StatisticsTeamCC).
/// </summary>
public class LoadStatisticsTeamCC : AbstractPacket
{
    public const int ID_CONST = -1233891872;
    public override int Id => ID_CONST;
    public override string Description => "Load team statistics (StatisticsTeamCC)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // blueScore
        IntCodec.Instance, // redScore
        new VectorCodec(UserInfoCodec.Instance, false), // usersInfoBlue (Vector<UserInfo>)
        new VectorCodec(UserInfoCodec.Instance, false) // usersInfoRed (Vector<UserInfo>)
    };

    public override string[] Attributes => new[]
    {
        "blueScore",
        "redScore",
        "usersInfoBlue",
        "usersInfoRed"
    };
}