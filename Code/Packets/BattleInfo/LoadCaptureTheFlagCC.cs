using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading Capture The Flag control center.
/// </summary>
public class LoadCaptureTheFlagCC : Packet
{
	[Encode(0)]
	public ClientFlag? BlueFlag { get; set; }

	[Encode(1)]
	public Resource? BlueFlagSprite { get; set; }

	[Encode(2)]
	public Resource? BluePedestalModel { get; set; }

	[Encode(3)]
	public ClientFlag? RedFlag { get; set; }

	[Encode(4)]
	public Resource? RedFlagSprite { get; set; }

	[Encode(5)]
	public Resource? RedPedestalModel { get; set; }

	[Encode(6)]
	public CaptureTheFlagSoundFX? Sounds { get; set; }

	public const int ID_CONST = 789790814;
	public override int Id => ID_CONST;
	public override string Description => "Load Capture The Flag control center";
}
