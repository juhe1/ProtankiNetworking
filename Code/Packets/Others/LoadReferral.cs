using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load garage
/// </summary>
public class LoadReferral : AbstractPacket
{
    public const int IdStatic = -169921234;
    public override int Id => IdStatic;
    public override string Description => "Load garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}