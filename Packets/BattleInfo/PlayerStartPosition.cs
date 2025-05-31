using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Player Start Position
    /// </summary>
    public class PlayerStartPosition : AbstractPacket
    {
        public static new int Id { get; } = -157204477;
        public static new string Description { get; } = "Player Start Position";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "position",
            "orientation",
        };
    }
}
