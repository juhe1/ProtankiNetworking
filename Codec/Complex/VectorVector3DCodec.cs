using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of Vector3D values
    /// </summary>
    public class VectorVector3DCodec : BaseCodec<Vector3D[]>
    {
        private readonly Vector3DCodec _vector3DCodec;

        /// <summary>
        /// Creates a new instance of VectorVector3DCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorVector3DCodec(EByteArray buffer) : base(buffer)
        {
            _vector3DCodec = new Vector3DCodec(buffer);
        }

        /// <summary>
        /// Decodes an array of Vector3D values from the buffer
        /// </summary>
        /// <returns>The decoded array of Vector3D values</returns>
        public override Vector3D[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Vector3D>();

            var result = new Vector3D[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _vector3DCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of Vector3D values to the buffer
        /// </summary>
        /// <param name="value">The array of Vector3D values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(Vector3D[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }

            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            foreach (var vector in value)
            {
                totalBytes += _vector3DCodec.Encode(vector);
            }
            return totalBytes;
        }
    }
} 