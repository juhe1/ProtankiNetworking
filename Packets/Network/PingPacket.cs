namespace ProboTankiLibCS.Packets.Network
{
    /// <summary>
    /// Ping Packet from server
    /// </summary>
    public class PingPacket : AbstractPacket
    {
        public static new int Id { get; } = -555602629;
        public static new string Description { get; } = "Ping Packet from server";
        public static new bool ShouldLog { get; } = false;
    }
} 