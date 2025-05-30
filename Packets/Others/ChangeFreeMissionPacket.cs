using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Change free mission
    /// </summary>
    public class ChangeFreeMissionPacket : AbstractPacket
    {
        public static new int Id { get; } = 326032325;
        public static new string Description { get; } = "Change free mission";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "missionId" };
    }
} 