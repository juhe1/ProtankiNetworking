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
        public static new int Id { get; } = -867767128;
        public static new string Description { get; } = "Accept mission";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "missionId",
        };
    }
}
