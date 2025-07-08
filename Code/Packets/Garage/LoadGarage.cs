using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Load garage
/// </summary>
public class LoadGarage : AbstractPacket
{
    public static int Id { get; } = -479046431;
    public override string Description => "Load garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}