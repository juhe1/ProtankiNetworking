namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Load settings
    /// </summary>
    public class LoadSettingsPacket : AbstractPacket
    {
        public static new int Id { get; } = 850220815;
        public static new string Description { get; } = "Load settings";
    }
} 