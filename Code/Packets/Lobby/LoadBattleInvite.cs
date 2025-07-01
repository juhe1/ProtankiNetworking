using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet for BattleInviteCC, containing a sound notification resource.
    /// </summary>
    public class LoadBattleInvite : AbstractPacket
    {
        public static int Id { get; } = 834877801;
        public override string Description => "BattleInviteCC packet with sound notification";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // soundNotification
        };
        public override string[] Attributes => new string[]
        {
            "soundNotification",
        };
    }
} 