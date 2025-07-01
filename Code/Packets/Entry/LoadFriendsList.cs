using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Loads the player's friend lists
    /// </summary>
    public class LoadFriendsList : AbstractPacket
    {
        public static int Id { get; } = 1422563374;
        public override string Description => "Loads the player's friend lists";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
