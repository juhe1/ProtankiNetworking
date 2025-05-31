using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Leaves battle to a layout (0 = Lobby, 1 = Garage)
    /// </summary>
    public class LeaveBattle : AbstractPacket
    {
        public static new int Id { get; } = 377959142;
        public static new string Description { get; } = "Leaves battle to a layout (0 = Lobby, 1 = Garage)";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "layout",
        };
    }
}
