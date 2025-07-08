using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for ClientFlag structure (flagBasePosition, flagCarrierId, flagPosition).
    /// </summary>
    public class ClientFlagCodec : CustomBaseCodec
    {
        public static ClientFlagCodec Instance { get; } = new ClientFlagCodec();

        protected override string[] Attributes => new[]
        {
            "flagBasePosition",
            "flagCarrierId",
            "flagPosition"
        };

        protected override ICodec[] CodecObjects => new ICodec[]
        {
            Vector3DCodec.Instance, // flagBasePosition
            StringCodec.Instance,   // flagCarrierId
            Vector3DCodec.Instance, // flagPosition
        };
    }
} 