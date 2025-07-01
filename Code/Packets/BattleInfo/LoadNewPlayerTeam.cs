using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// A new player has joined the team battle
    /// </summary>
    public class LoadNewPlayerTeam : AbstractPacket
    {
        public static int Id { get; } = 2040021062;
        public override string Description => "A new player has joined the team battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            new VectorCodec(BattleUserCodec.Instance, false),
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "userinfos",
            "team",
        };
    }
}
