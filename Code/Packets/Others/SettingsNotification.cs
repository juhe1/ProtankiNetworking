using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Check if the user has notification on
/// </summary>
public class SettingsNotification : AbstractPacket
{
    public static int IdStatic { get; } = 1447082276;
    public override int Id => IdStatic;
    public override string Description => "Check if the user has notification on";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "notificationEnabled"
    };
}