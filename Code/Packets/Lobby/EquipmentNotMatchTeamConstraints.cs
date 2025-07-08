using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet to show a warning that the player is trying to join a team battle with wrong equipment.
    /// </summary>
    public class EquipmentNotMatchTeamConstraints : AbstractPacket
    {
        public static int Id { get; } = -10847382;
        public override string Description => "Warns that the player is trying to join a team battle with wrong equipment.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // battleTeamInfoObjectId
        };
        public override string[] Attributes => new string[]
        {
            "battleTeamInfoObjectId",
        };
    }
} 