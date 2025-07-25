using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Ping Packet from server
/// </summary>
public class Ping : AbstractPacket
{
    public const int ID_CONST = -555602629;
    public override int Id => ID_CONST;
    public override string Description => "Ping Packet from server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}