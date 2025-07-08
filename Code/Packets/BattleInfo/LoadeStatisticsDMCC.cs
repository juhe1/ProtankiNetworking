using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for loading DM statistics (usersInfo: Vector<UserInfo>).
    /// </summary>
    public class LoadeStatisticsDMCC : AbstractPacket
    {
        public static int Id { get; } = -1959138292;
        public override string Description => "Load DM statistics (usersInfo: Vector<UserInfo>)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(UserInfoCodec.Instance, false), // usersInfo
        };
        public override string[] Attributes => new string[]
        {
            "usersInfo",
        };
    }
} 