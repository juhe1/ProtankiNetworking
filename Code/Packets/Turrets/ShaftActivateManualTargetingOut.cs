using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft activate manual targeting out (no attributes).
/// </summary>
public class ShaftActivateManualTargetingOut : AbstractPacket
{
    public static int IdStatic { get; } = -1487306515;
    public override int Id => IdStatic;
    public override string Description => "Shaft activate manual targeting out (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
}