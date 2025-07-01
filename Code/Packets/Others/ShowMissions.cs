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
        public static int Id { get; } = 809822533;
        public override string Description => "Show the list of missions currently available to the player";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(MissionCodec.Instance, false),
            MissionStreakCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "missions",
            "weeklyStreakInfo",
        };
    }
}
