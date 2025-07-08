using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for BattleMine structure used in battle mine configuration.
    /// </summary>
    public class BattleMineCodec : CustomBaseCodec
    {
        public static BattleMineCodec Instance { get; } = new BattleMineCodec();

        protected override string[] Attributes => new[]
        {
            "mineId",
            "ownerId",
            "position"
        };

        protected override ICodec[] CodecObjects => new ICodec[]
        {
            StringCodec.Instance, // mineId
            StringCodec.Instance, // ownerId
            Vector3DCodec.Instance, // position
        };
    }
} 