namespace ProtankiNetworking.Packets.BattleInfo
{
	/// <summary>
	/// Information about the ping of the player.
	/// </summary>
	public class BattlePingInfo : Packet
	{
		[Encode(0)]
		public int ServerSessionTime { get; set; }

		[Encode(1)]
		public int ClientPing { get; set; }

		public const int ID_CONST = 34068208;
		public override int Id => ID_CONST;
		public override string Description => "Information about the ping of the player.";
	}
}
