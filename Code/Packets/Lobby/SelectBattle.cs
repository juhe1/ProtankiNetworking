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
        public static int Id { get; } = 2092412133;
        public override string Description => "Client selects a battle / Server confirms selection of battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
        };
    }
}
