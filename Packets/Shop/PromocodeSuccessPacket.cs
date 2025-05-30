namespace ProboTankiLibCS.Packets.Shop
{
    /// <summary>
    /// Promocode applied successfully
    /// </summary>
    public class PromocodeSuccessPacket : AbstractPacket
    {
        public static new int Id { get; } = -1859441081;
        public static new string Description { get; } = "Promocode applied successfully";
    }
} 