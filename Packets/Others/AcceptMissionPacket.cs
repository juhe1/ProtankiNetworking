using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Accept mission
    /// </summary>
    public class AcceptMissionPacket : AbstractPacket
    {
        public static new int Id { get; } = -867767128;
        public static new string Description { get; } = "Accept mission";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "missionId" };
    }
} 