using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class InBattleStatusInPacket : Packet
{

	[Encode(0)]
	public BattleNotifierData? UserInfo { get; set; }

	public const int ID_CONST = -1895446889;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
