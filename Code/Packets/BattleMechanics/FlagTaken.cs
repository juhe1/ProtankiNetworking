using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for when a flag is taken by a tank.
    /// </summary>
    public class FlagTaken : AbstractPacket
    {
        public static int Id { get; } = -1282406496;
        public override string Description => "Flag taken by tank";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // tankId
            BattleTeamCodec.Instance, // flagTeam
        };
        public override string[] Attributes => new string[]
        {
            "tankId",
            "flagTeam",
        };
    }
} 