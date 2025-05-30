namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Sends a self destruct request to the server
    /// </summary>
    public class SelfDestructPacket : AbstractPacket
    {
        public static new int Id { get; } = 988664577;
        public static new string Description { get; } = "Sends a self destruct request to the server";
    }
} 