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
        public static new int Id { get; } = 1422563374;
        public static new string Description { get; } = "Loads the player's friend lists";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
