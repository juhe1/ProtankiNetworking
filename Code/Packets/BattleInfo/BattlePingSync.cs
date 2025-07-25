

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Attempts to sync ping information with the server
    /// </summary>
    public class BattlePingSync : Packet
    {
        [Encode(0)]
        public int ClientTime { get; set; }

        [Encode(1)]
        public int ServerSessionTime { get; set; }

        public const int ID_CONST = 2074243318;
        public override int Id => ID_CONST;
    public override string Description => "Attempts to sync ping information with the server";


    }
}