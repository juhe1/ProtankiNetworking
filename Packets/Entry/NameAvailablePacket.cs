namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Said name is available for registration
    /// </summary>
    public class NameAvailablePacket : AbstractPacket
    {
        public static new int Id { get; } = -706679202;
        public static new string Description { get; } = "Said name is available for registration";
    }
} 