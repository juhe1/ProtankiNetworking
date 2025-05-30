using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Receives movement data of a player from the server.
    /// </summary>
    public class MovedPacket : AbstractPacket
    {
        public static new int Id { get; } = -64696933;
        public static new string Description { get; } = "Receives movement data of a player from the server.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(MoveCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "movement" };
    }
} 