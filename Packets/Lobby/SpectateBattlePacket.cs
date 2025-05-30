namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Client requests to spectate the selected battle
    /// </summary>
    public class SpectateBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -1315002220;
        public static new string Description { get; } = "Client requests to spectate the selected battle";
    }
} 