using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// A new player has joined the battle
    /// </summary>
    public class LoadNewPlayerDm : AbstractPacket
    {
        public static new int Id { get; } = 862913394;
        public static new string Description { get; } = "A new player has joined the battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            new VectorCodec(BattleUserCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "userinfos",
        };
    }
}
