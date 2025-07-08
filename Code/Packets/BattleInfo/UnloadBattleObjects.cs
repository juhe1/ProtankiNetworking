using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for unloading battle objects.
    /// </summary>
    public class UnloadBattleObjects : AbstractPacket
    {
        public static int Id { get; } = -985579124;
        public override string Description => "Unload battle objects";
        public override BaseCodec[] CodecObjects => new BaseCodec[] { };
        public override string[] Attributes => new string[] { };
    }
} 