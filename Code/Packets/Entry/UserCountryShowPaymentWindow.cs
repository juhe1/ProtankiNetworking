using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for showing the user payment window (no attributes).
/// </summary>
public class UserCountryShowPaymentWindow : AbstractPacket
{
    public const int ID_CONST = 1870342869;
    public override int Id => ID_CONST;
    public override string Description => "User country show payment window (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 