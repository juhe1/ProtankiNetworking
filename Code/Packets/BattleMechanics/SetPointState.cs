using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;
// using ProtankiNetworking.Codec.Custom; // Uncomment if ControlPointStateCodec is implemented

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for setting the state of a control point (pointId, state).
    /// </summary>
    public class SetPointState : AbstractPacket
    {
        public static int Id { get; } = -1073178885;
        public override string Description => "Set point state (pointId, state)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // pointId
            ControlPointStateCodec.Instance, // state
        };
        public override string[] Attributes => new string[]
        {
            "pointId",
            "state",
        };
    }
} 