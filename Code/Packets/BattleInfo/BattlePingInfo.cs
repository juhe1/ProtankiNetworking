using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Information about the ping of the player.
    /// </summary>
    public class BattlePingInfo : AbstractPacket
    {
        public static int Id { get; } = 34068208;
        public override string Description => "Information about the ping of the player.";

        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
        };

        public override string[] Attributes => new string[]
        {
            "serverSessionTime",
            "clientPing",
        };
    }
}