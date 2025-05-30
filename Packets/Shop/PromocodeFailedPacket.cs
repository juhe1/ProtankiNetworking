namespace ProboTankiLibCS.Packets.Shop
{
    /// <summary>
    /// Incorrect or expired promocode
    /// </summary>
    public class PromocodeFailedPacket : AbstractPacket
    {
        public static new int Id { get; } = -1850050333;
        public static new string Description { get; } = "Incorrect or expired promocode";
    }
} 