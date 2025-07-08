using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load settings
/// </summary>
public class LoadSettings : AbstractPacket
{
    public static int Id { get; } = 850220815;
    public override string Description => "Load settings";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}