using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets
{
    /// <summary>
    /// Represents a packet with an unknown type
    /// </summary>
    public class UnknownPacket : AbstractPacket
    {
        /// <summary>
        /// The raw packet data
        /// </summary>
        public ByteArray RawData => (ByteArray)Objects[0];

        /// <summary>
        /// The ID of the unknown packet
        /// </summary>
        public int PacketId => Id;

        public UnknownPacket()
        {
            // Set up the packet to store raw data
            Objects.Add(new ByteArray());
            ObjectByAttributeName["data"] = Objects[0];
        }
    }
} 