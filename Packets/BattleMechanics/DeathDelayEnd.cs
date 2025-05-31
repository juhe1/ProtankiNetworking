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
        public static new int Id { get; } = 268832557;
        public static new string Description { get; } = "Respawn delay ends and player can start respawning";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
