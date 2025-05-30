using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Sends your movement data to the server
    /// </summary>
    public class MovePacket : AbstractPacket
    {
        // last_client_time = 0
        // last_pos_z = 0

        public static new int Id { get; } = 329279865;
        public static new string Description { get; } = "Sends your movement data to the server";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(ShortCodec), typeof(MoveCodec) };
        public static new string[] Attributes { get; } = new[] { "clientTime", "specificationID", "movement" };
    }
} 