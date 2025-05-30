using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Do we need an invite code to access the server?
    /// </summary>
    public class InviteCodeStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = 444933603;
        public static new string Description { get; } = "Do we need an invite code to access the server?";
        public static new Type[] CodecTypes { get; } = new[] { typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "inviteEnabled" };
    }
} 