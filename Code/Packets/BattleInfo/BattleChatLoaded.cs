namespace ProtankiNetworking.Packets.BattleInfo
{
	/// <summary>
	/// Packet to indicate that the battle chat has loaded.
	/// </summary>
	public class BattleChatLoaded : Packet
	{
		public const int ID_CONST = -643105296;
		public override int Id => ID_CONST;
		public override string Description => "Indicates that the battle chat has loaded";
	}
}
