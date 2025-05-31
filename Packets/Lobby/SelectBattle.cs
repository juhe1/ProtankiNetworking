using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Client selects a battle / Server confirms selection of battle
    /// </summary>
    public class SelectBattle : AbstractPacket
    {
        public static new int Id { get; } = 2092412133;
        public static new string Description { get; } = "Client selects a battle / Server confirms selection of battle";
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
