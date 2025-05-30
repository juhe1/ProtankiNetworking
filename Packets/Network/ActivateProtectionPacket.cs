using System;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Network
{
    /// <summary>
    /// Contains the keys required to activate packet encryption
    /// </summary>
    public class ActivateProtectionPacket : AbstractPacket
    {
        public static new int Id { get; } = 2001736388;
        public static new string Description { get; } = "Contains the keys required to activate packet encryption";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorIntCodec) };
        public static new string[] Attributes { get; } = new[] { "keys" };
    }
} 