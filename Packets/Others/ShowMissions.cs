using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Show the list of missions currently available to the player
    /// </summary>
    public class ShowMissions : AbstractPacket
    {
        public static new int Id { get; } = 809822533;
        public static new string Description { get; } = "Show the list of missions currently available to the player";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(MissionCodec.Instance, false),
            MissionStreakCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "missions",
            "weeklyStreakInfo",
        };
    }
}
