using System;
using System.Text;

namespace ProtankiNetworking.Utils
{
    /// <summary>
    /// Enhanced byte array class that provides methods for reading and writing various data types
    /// </summary>
    public class EByteArray : ByteArray
    {
        /// <summary>
        /// Creates a new empty EByteArray
        /// </summary>
        public EByteArray() : base()
        {
        }

        /// <summary>
        /// Creates a new EByteArray from an existing byte array
        /// </summary>
        /// <param name="buffer">The byte array to use</param>
        public EByteArray(byte[] buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Reads a 32-bit integer from the current position
        /// </summary>
        /// <returns>The integer read</returns>
        public int ReadInt()
        {
            var bytes = ReadBytes(4);
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// Reads a 16-bit integer from the current position
        /// </summary>
        /// <returns>The short read</returns>
        public short ReadShort()
        {
            var bytes = ReadBytes(2);
            return BitConverter.ToInt16(bytes, 0);
        }

        /// <summary>
        /// Reads a single byte from the current position
        /// </summary>
        /// <returns>The byte read</returns>
        public new byte ReadByte()
        {
            return base.ReadByte();
        }

        /// <summary>
        /// Reads a boolean from the current position
        /// </summary>
        /// <returns>The boolean read</returns>
        public bool ReadBoolean()
        {
            return ReadByte() != 0;
        }

        /// <summary>
        /// Reads a 32-bit floating point number from the current position
        /// </summary>
        /// <returns>The float read</returns>
        public float ReadFloat()
        {
            var bytes = ReadBytes(4);
            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        /// Reads a string of specified length from the current position
        /// </summary>
        /// <param name="length">The length of the string to read</param>
        /// <returns>The string read</returns>
        public string ReadString(int length)
        {
            var bytes = ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// Writes a 32-bit integer to the current position
        /// </summary>
        /// <param name="value">The integer to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteInt(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            Write(bytes);
            return this;
        }

        /// <summary>
        /// Writes a 16-bit integer to the current position
        /// </summary>
        /// <param name="value">The short to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteShort(short value)
        {
            var bytes = BitConverter.GetBytes(value);
            Write(bytes);
            return this;
        }

        /// <summary>
        /// Writes a single byte to the current position
        /// </summary>
        /// <param name="value">The byte to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteByte(byte value)
        {
            Write(value);
            return this;
        }

        /// <summary>
        /// Writes a boolean to the current position
        /// </summary>
        /// <param name="value">The boolean to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteBoolean(bool value)
        {
            WriteByte((byte)(value ? 1 : 0));
            return this;
        }

        /// <summary>
        /// Writes a 32-bit floating point number to the current position
        /// </summary>
        /// <param name="value">The float to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteFloat(float value)
        {
            var bytes = BitConverter.GetBytes(value);
            Write(bytes);
            return this;
        }

        /// <summary>
        /// Writes a string to the current position
        /// </summary>
        /// <param name="value">The string to write</param>
        /// <returns>This EByteArray instance for method chaining</returns>
        public EByteArray WriteString(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            Write(bytes);
            return this;
        }

        /// <summary>
        /// Trims the packet data for display
        /// </summary>
        /// <param name="trimLength">The maximum length before trimming</param>
        /// <returns>A new EByteArray with trimmed data</returns>
        public EByteArray Trim(int trimLength = 300)
        {
            if (Length <= trimLength)
                return this;

            var result = new EByteArray();
            result.Write(ReadBytes(150));
            result.Write(Encoding.UTF8.GetBytes("..."));
            Position = Length - 150;
            result.Write(ReadBytes(150));
            return result;
        }
    }
} 