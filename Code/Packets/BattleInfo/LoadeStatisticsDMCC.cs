using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading DM statistics (usersInfo: Vector<UserInfo>).
/// </summary>
public class LoadeStatisticsDMCC : AbstractPacket
{
    public static int IdStatic { get; } = -1959138292;
    public override int Id => IdStatic;
    public override string Description => "Load DM statistics (usersInfo: Vector<UserInfo>)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(UserInfoCodec.Instance, false) // usersInfo
    };

    public override string[] Attributes => new[]
    {
        "usersInfo"
    };
}