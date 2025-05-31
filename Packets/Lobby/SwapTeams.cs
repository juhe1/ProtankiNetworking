using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Swaps teams in a battle
    /// </summary>
    public class SwapTeams : AbstractPacket
    {
        public static new int Id { get; } = -994817471;
        public static new string Description { get; } = "Swaps teams in a battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
        };
    }
}
