using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load garage
/// </summary>
public class LoadReferral : AbstractPacket
{
    public const int ID_CONST = -169921234;
    public override int Id => ID_CONST;
    public override string Description => "Load garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}