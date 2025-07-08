using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for UserInfo structure used in team statistics.
    /// </summary>
    public class UserInfoCodec : CustomBaseCodec
    {
        public static UserInfoCodec Instance { get; } = new UserInfoCodec();

        protected override string[] Attributes => new[]
        {
            "chatModeratorLevel",
            "deaths",
            "kills",
            "rank",
            "score",
            "uid"
        };

        protected override ICodec[] CodecObjects => new ICodec[]
        {
            ChatModeratorLevelCodec.Instance, // chatModeratorLevel
            IntCodec.Instance, // deaths
            IntCodec.Instance, // kills
            ByteCodec.Instance, // rank
            IntCodec.Instance, // score
            StringCodec.Instance, // uid
        };
    }
} 