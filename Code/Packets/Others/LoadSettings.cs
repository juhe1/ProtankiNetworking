using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load settings
/// </summary>
public class LoadSettings : AbstractPacket
{
    public const int IdStatic = 850220815;
    public override int Id => IdStatic;
    public override string Description => "Load settings";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}