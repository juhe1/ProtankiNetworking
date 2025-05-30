namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Client end the Fantom period to fully spawn
    /// </summary>
    public class EndRespFantomPacket : AbstractPacket
    {
        public static new int Id { get; } = 1178028365;
        public static new string Description { get; } = "Client end the Fantom period to fully spawn";
    }
} 