

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for signaling that a DM object has loaded (no attributes).
    /// </summary>
    public class BattleDMObjectLoadedPost : Packet
    {
        public const int ID_CONST = 930618015;
        public override int Id => ID_CONST;
    public override string Description => "Battle DM object loaded post (no attributes)";
    }
}