using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Respawn delay ends and player can start respawning
    /// </summary>
    public class DeathDelayEnd : AbstractPacket
    {
        public static int Id { get; } = 268832557;
        public override string Description => "Respawn delay ends and player can start respawning";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
