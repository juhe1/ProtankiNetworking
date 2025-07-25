

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle fund
    /// </summary>
    public class BattleFund : Packet
    {
        [Encode(0)]
        public int Fund { get; set; }

        public const int ID_CONST = 1149211509;
        public override int Id => ID_CONST;
    public override string Description => "Battle fund";


    }
}