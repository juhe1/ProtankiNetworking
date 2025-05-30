namespace ProboTankiLibCS.Packets.Network
{
    /// <summary>
    /// Pong Packet from client
    /// </summary>
    public class PongPacket : AbstractPacket
    {
        public static new int Id { get; } = 1484572481;
        public static new string Description { get; } = "Pong Packet from client";
        public static new bool ShouldLog { get; } = false;
    }
} 