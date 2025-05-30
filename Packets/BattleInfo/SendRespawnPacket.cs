namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Send Respawn(fantom) Packet
    /// </summary>
    public class SendRespawnPacket : AbstractPacket
    {
        public static new int Id { get; } = -1378839846;
        public static new string Description { get; } = "Send Respawn(fantom) Packet";
    }
} 