using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for returning a flag to base, specifying the team and tank.
    /// </summary>
    public class ReturnFlagToBase : AbstractPacket
    {
        public static int Id { get; } = -1026428589;
        public override string Description => "Return flag to base (team and tank)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BattleTeamCodec.Instance, // flagTeam
            StringCodec.Instance, // tank
        };
        public override string[] Attributes => new string[]
        {
            "flagTeam",
            "tank",
        };
    }
} 