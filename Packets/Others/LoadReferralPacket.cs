namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Load garage
    /// </summary>
    public class LoadReferralPacket : AbstractPacket
    {
        public static new int Id { get; } = -169921234;
        public static new string Description { get; } = "Load garage";
    }
} 