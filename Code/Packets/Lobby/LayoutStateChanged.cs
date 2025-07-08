using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet for notifying about a layout state change.
    /// </summary>
    public class LayoutStateChanged : AbstractPacket
    {
        public static int Id { get; } = -593368100;
        public override string Description => "Notifies about a layout state change";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            LayoutStateCodec.Instance, // origin
            LayoutStateCodec.Instance, // lastState
        };
        public override string[] Attributes => new string[]
        {
            "origin",
            "lastState",
        };
    }
} 