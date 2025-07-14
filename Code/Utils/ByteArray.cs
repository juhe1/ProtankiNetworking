namespace ProtankiNetworking.Utils;

/// <summary>
///     Enhanced byte array class that provides basic byte array operations
/// </summary>
public class ByteArray
{
    private byte[] _buffer;
    private int _position;

    /// <summary>
    ///     Creates a new empty ByteArray
    /// </summary>
    public ByteArray()
    {
        _buffer = Array.Empty<byte>();
        _position = 0;
    }

    /// <summary>
    ///     Creates a new ByteArray from an existing byte array
    /// </summary>
    /// <param name="buffer">The byte array to use</param>
    public ByteArray(byte[] buffer)
    {
        _buffer = buffer;
        _position = 0;
    }

    /// <summary>
    ///     Gets the length of the buffer
    /// </summary>
    public int Length => _buffer.Length;

    /// <summary>
    ///     Gets or sets the current position in the buffer
    /// </summary>
    public int Position
    {
        get => _position;
        set => _position = Math.Clamp(value, 0, Length);
    }

    /// <summary>
    ///     Converts the ByteArray to a regular byte array
    /// </summary>
    /// <returns>The underlying byte array</returns>
    public byte[] ToArray()
    {
        return _buffer;
    }

    /// <summary>
    ///     Returns only the written portion of the buffer (from 0 to _position)
    /// </summary>
    /// <returns>The trimmed byte array</returns>
    public byte[] ToTrimmedArray()
    {
        var result = new byte[_position];
        Array.Copy(_buffer, result, _position);
        return result;
    }

    /// <summary>
    ///     Reads a byte from the current position
    /// </summary>
    /// <returns>The byte read</returns>
    public byte ReadByte()
    {
        if (_position >= Length)
            throw new IndexOutOfRangeException("Attempted to read past the end of the buffer");

        return _buffer[_position++];
    }

    /// <summary>
    ///     Reads a specified number of bytes from the current position
    /// </summary>
    /// <param name="count">The number of bytes to read</param>
    /// <returns>The bytes read</returns>
    public byte[] ReadBytes(int count)
    {
        if (_position + count > Length)
            throw new IndexOutOfRangeException("Attempted to read past the end of the buffer");

        var result = new byte[count];
        Array.Copy(_buffer, _position, result, 0, count);
        _position += count;
        return result;
    }

    /// <summary>
    ///     Writes a byte to the current position
    /// </summary>
    /// <param name="value">The byte to write</param>
    /// <returns>This ByteArray instance for method chaining</returns>
    public ByteArray Write(byte value)
    {
        EnsureCapacity(1);
        _buffer[_position++] = value;
        return this;
    }

    /// <summary>
    ///     Writes a byte array to the current position
    /// </summary>
    /// <param name="value">The byte array to write</param>
    /// <returns>This ByteArray instance for method chaining</returns>
    public ByteArray Write(byte[] value)
    {
        EnsureCapacity(value.Length);
        value.CopyTo(_buffer, _position);
        _position += value.Length;
        return this;
    }

    /// <summary>
    ///     Writes a ByteArray to the current position
    /// </summary>
    /// <param name="value">The ByteArray to write</param>
    /// <returns>This ByteArray instance for method chaining</returns>
    public ByteArray Write(ByteArray value)
    {
        return Write(value.ToArray());
    }

    /// <summary>
    ///     Ensures the buffer has enough capacity for the specified number of bytes
    /// </summary>
    /// <param name="requiredBytes">The number of bytes required</param>
    private void EnsureCapacity(int requiredBytes)
    {
        if (_position + requiredBytes > Length)
        {
            var newBuffer = new byte[Math.Max(_buffer.Length * 2, _position + requiredBytes)];
            Array.Copy(_buffer, newBuffer, _buffer.Length);
            _buffer = newBuffer;
        }
    }

    /// <summary>
    ///     Creates an EByteArray from this ByteArray
    /// </summary>
    /// <returns>A new EByteArray containing the same data</returns>
    public EByteArray ToEByteArray()
    {
        return new EByteArray(ToArray());
    }
}