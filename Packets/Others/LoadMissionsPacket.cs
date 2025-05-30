namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// User requests to load their missions
    /// </summary>
    public class LoadMissionsPacket : AbstractPacket
    {
        public static new int Id { get; } = 1227293080;
        public static new string Description { get; } = "User requests to load their missions";
    }
} 