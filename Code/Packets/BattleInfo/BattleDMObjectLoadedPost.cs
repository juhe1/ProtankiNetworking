using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for signaling that a DM object has loaded (no attributes).
    /// </summary>
    public class BattleDMObjectLoadedPost : AbstractPacket
    {
        public const int ID_CONST = 930618015;
        public override int Id => ID_CONST;
    public override string Description => "Battle DM object loaded post (no attributes)";
        public override BaseCodec[] CodecObjects => new BaseCodec[] { };
        public override string[] Attributes => new string[] { };
    }
}