using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Accept mission
    /// </summary>
    public class AcceptMission : AbstractPacket
    {
        public static int Id { get; } = -867767128;
        public override string Description => "Accept mission";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "missionId",
        };
    }
}
