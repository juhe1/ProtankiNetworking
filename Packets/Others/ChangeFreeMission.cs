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
        public static int Id { get; } = 326032325;
        public override string Description => "Change free mission";
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
