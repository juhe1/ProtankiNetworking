namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// A mission was completed and is available to claim
    /// </summary>
    public class CompletedMissionPacket : AbstractPacket
    {
        public static new int Id { get; } = 1579425801;
        public static new string Description { get; } = "A mission was completed and is available to claim";
    }
} 