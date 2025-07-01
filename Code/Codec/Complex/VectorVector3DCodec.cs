using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for vector of Vector3D values
    /// </summary>
    public class VectorVector3DCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of VectorVector3DCodec
        /// </summary>
        public static VectorVector3DCodec Instance { get; } = new VectorVector3DCodec(Vector3DCodec.Instance);

        private readonly ICodec _vector3DCodec;

        /// <summary>
        /// Creates a new instance of VectorVector3DCodec
        /// </summary>
        /// <param name="vector3DCodec">The codec to use for Vector3D values</param>
        public VectorVector3DCodec(ICodec vector3DCodec)
        {
            _vector3DCodec = vector3DCodec;
        }

        /// <summary>
        /// Decodes a vector of Vector3D values from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector of Vector3D values</returns>
        public override object Decode(EByteArray buffer)
        {
            var length = buffer.ReadInt();
            var result = new List<Vector3D>();
            for (int i = 0; i < length; i++)
            {
                result.Add((Vector3D)_vector3DCodec.Decode(buffer));
            }
            return result;
        }

        /// <summary>
        /// Encodes a vector of Vector3D values to the buffer
        /// </summary>
        /// <param name="value">The vector of Vector3D values to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not List<Vector3D> list)
            {
                throw new ArgumentException("Value must be a list of Vector3D", nameof(value));
            }

            var bytesWritten = 0;
            buffer.WriteInt(list.Count);
            bytesWritten += 4;

            foreach (var vector in list)
            {
                bytesWritten += _vector3DCodec.Encode(vector, buffer);
            }
            return bytesWritten;
        }
    }
} 