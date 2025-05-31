using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Player Equipment.
    /// </summary>
    public class PlayerEquipment : AbstractPacket
    {
        public static new int Id { get; } = -1643824092;
        public static new string Description { get; } = "Player Equipment.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
