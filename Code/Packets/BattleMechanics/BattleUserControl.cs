namespace ProtankiNetworking.Packets.BattleMechanics
{
	/// <summary>
	/// Battle user control packet
	/// </summary>
	public class BattleUserControl : Packet
	{
		[Encode(0)]
		public string? TankiId { get; set; }

		[Encode(1)]
		public byte Control { get; set; }

		public const int ID_CONST = -301298508;
		public override int Id => ID_CONST;
		public override string Description => "Battle user control packet";
	}
}
