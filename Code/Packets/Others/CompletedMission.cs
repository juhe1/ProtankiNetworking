using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     A mission was completed and is available to claim
/// </summary>
public class CompletedMission : AbstractPacket
{
    public const int ID_CONST = 1579425801;
    public override int Id => ID_CONST;
    public override string Description => "A mission was completed and is available to claim";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}