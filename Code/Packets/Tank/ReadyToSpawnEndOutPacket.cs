using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ReadyToSpawnEndOutPacket : Packet
{

	public const int ID_CONST = 268832557;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
