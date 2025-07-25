namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Initializes premium status and related notifications for the user.
/// </summary>
public class InitPremium : Packet
{
	[Encode(0)]
	public bool NeedShowNotificationCompletionPremium { get; set; }

	[Encode(1)]
	public bool NeedShowWelcomeAlert { get; set; }

	[Encode(2)]
	public float ReminderCompletionPremiumTime { get; set; }

	[Encode(3)]
	public bool WasShowAlertForFirstPurchasePremium { get; set; }

	[Encode(4)]
	public bool WasShowReminderCompletionPremium { get; set; }

	[Encode(5)]
	public int LifeTimeInSeconds { get; set; }

	public const int ID_CONST = 1405859779;
	public override int Id => ID_CONST;
	public override string Description => "Initialize premium status and notifications";
}
