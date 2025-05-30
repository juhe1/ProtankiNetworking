namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Respawn delay ends and player can start respawning
    /// </summary>
    public class DeathDelayEndPacket : AbstractPacket
    {
        public static new int Id { get; } = 268832557;
        public static new string Description { get; } = "Respawn delay ends and player can start respawning";
    }
} 