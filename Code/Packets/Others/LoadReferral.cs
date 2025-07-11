using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load garage
/// </summary>
public class LoadReferral : AbstractPacket
{
    public static int IdStatic { get; } = -169921234;
    public override int Id => IdStatic;
    public override string Description => "Load garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}