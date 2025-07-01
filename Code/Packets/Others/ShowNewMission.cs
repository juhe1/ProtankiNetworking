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
        public static int Id { get; } = -1266665816;
        public override string Description => "Show the new mission that was previously changed";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            MissionCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "missionId",
            "mission",
        };
    }
}
