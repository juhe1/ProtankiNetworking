namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Login failed
    /// </summary>
    public class LoginFailedPacket : AbstractPacket
    {
        public static new int Id { get; } = 103812952;
        public static new string Description { get; } = "Login failed";
    }
} 