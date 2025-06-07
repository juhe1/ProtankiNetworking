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
        public static int Id { get; } = -1767633906;
        public override string Description => "User Changed Equipment";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "tank",
        };
    }
}
