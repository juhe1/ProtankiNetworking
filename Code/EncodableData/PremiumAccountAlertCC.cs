using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class PremiumAccountAlertCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

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

}
