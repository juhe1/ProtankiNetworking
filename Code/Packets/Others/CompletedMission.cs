using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     A mission was completed and is available to claim
/// </summary>
public class CompletedMission : AbstractPacket
{
    public static int IdStatic { get; } = 1579425801;
    public override int Id => IdStatic;
    public override string Description => "A mission was completed and is available to claim";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}