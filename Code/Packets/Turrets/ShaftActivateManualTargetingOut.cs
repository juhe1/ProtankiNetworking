using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft activate manual targeting out (no attributes).
/// </summary>
public class ShaftActivateManualTargetingOut : AbstractPacket
{
    public const int ID_CONST = -1487306515;
    public override int Id => ID_CONST;
    public override string Description => "Shaft activate manual targeting out (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
}