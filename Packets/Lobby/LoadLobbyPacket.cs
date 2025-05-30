namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Load battle info
    /// </summary>
    public class LoadLobbyPacket : AbstractPacket
    {
        public static new int Id { get; } = 1452181070;
        public static new string Description { get; } = "Load battle info";
    }
} 