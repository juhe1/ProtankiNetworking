using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Load garage
/// </summary>
public class LoadGarage : AbstractPacket
{
    public const int ID_CONST = -479046431;
    public override int Id => ID_CONST;
    public override string Description => "Load garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}