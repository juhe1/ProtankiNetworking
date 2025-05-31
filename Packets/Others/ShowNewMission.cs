using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Show the new mission that was previously changed
    /// </summary>
    public class ShowNewMission : AbstractPacket
    {
        public static new int Id { get; } = -1266665816;
        public static new string Description { get; } = "Show the new mission that was previously changed";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            MissionCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "missionId",
            "mission",
        };
    }
}
