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
        public static int Id { get; } = -157204477;
        public override string Description => "Player Start Position";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "position",
            "orientation",
        };
    }
}
