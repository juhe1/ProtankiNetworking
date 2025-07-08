using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for signaling that a DM object has loaded (no attributes).
    /// </summary>
    public class BattleDMObjectLoadedPost : AbstractPacket
    {
        public static int IdStatic { get; } = 930618015;
        public override int Id => IdStatic;
    public override string Description => "Battle DM object loaded post (no attributes)";
        public override BaseCodec[] CodecObjects => new BaseCodec[] { };
        public override string[] Attributes => new string[] { };
    }
}