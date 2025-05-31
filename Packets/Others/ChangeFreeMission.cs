using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Change free mission
    /// </summary>
    public class ChangeFreeMission : AbstractPacket
    {
        public static new int Id { get; } = 326032325;
        public static new string Description { get; } = "Change free mission";
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
