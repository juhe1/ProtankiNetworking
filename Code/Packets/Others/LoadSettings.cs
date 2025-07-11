using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load settings
/// </summary>
public class LoadSettings : AbstractPacket
{
    public const int ID_CONST = 850220815;
    public override int Id => ID_CONST;
    public override string Description => "Load settings";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}