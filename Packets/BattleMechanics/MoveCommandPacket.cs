using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Receives movement data of a player from the server.
    /// </summary>
    public class MoveCommandPacket : AbstractPacket
    {
        public static new int Id { get; } = 1516578027;
        public static new string Description { get; } = "Receives movement data of a player from the server.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(MoveCodec), typeof(FloatCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "movement", "turretDirection" };
    }
} 