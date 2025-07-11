using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for notifying about a layout state change.
/// </summary>
public class LayoutStateChanged : AbstractPacket
{
    public const int ID_CONST = -593368100;
    public override int Id => ID_CONST;
    public override string Description => "Notifies about a layout state change";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        LayoutStateCodec.Instance, // origin
        LayoutStateCodec.Instance // lastState
    };

    public override string[] Attributes => new[]
    {
        "origin",
        "lastState"
    };
}