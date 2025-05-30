using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for Vector3D values
    /// </summary>
    public class Vector3DCodec : BaseCodec<Vector3D>
    {
        /// <summary>
        /// Creates a new instance of Vector3DCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public Vector3DCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a Vector3D value from the buffer
        /// </summary>
        /// <returns>The decoded Vector3D value</returns>
        public override Vector3D Decode()
        {
            var x = Buffer.ReadFloat();
            var y = Buffer.ReadFloat();
            var z = Buffer.ReadFloat();
            return new Vector3D(x, y, z);
        }

        /// <summary>
        /// Encodes a Vector3D value to the buffer
        /// </summary>
        /// <param name="value">The Vector3D value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(Vector3D value)
        {
            Buffer.WriteFloat(value.X);
            Buffer.WriteFloat(value.Y);
            Buffer.WriteFloat(value.Z);
            return 12;
        }
    }
} 