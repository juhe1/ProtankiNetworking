using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Panel;

public class LoadAccountStatsInPacket : Packet
{

	[Encode(0)]
	public UserPropertiesCC? UserPropertyCC { get; set; }

	public const int ID_CONST = 907073245;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
