using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// User Changed Equipment
    /// </summary>
    public class UserChangedEquipment : AbstractPacket
    {
        public static new int Id { get; } = -1767633906;
        public static new string Description { get; } = "User Changed Equipment";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "tank",
        };
    }
}
