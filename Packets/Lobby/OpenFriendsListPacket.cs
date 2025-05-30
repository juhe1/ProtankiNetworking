namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Open Friends List
    /// </summary>
    public class OpenFriendsListPacket : AbstractPacket
    {
        public static new int Id { get; } = 1441234714;
        public static new string Description { get; } = "Open Friends List";
    }
} 