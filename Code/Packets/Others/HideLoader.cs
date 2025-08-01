using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Hides the loading screen or loader UI element
/// </summary>
public class HideLoader : AbstractPacket
{
    public const int ID_CONST = -1282173466;
    public override int Id => ID_CONST;
    public override string Description => "Hide the loader UI element";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}