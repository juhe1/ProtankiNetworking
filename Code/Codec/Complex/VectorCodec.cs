using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex;

/// <summary>
///     Codec for vector values
/// </summary>
public class VectorCodec : BaseCodec
{
    private readonly ICodec _elementCodec;
    private readonly bool _shorten;

    /// <summary>
    ///     Creates a new instance of VectorCodec
    /// </summary>
    /// <param name="elementCodec">The codec to use for vector elements</param>
    /// <param name="shorten">Whether to use shortened encoding</param>
    public VectorCodec(ICodec elementCodec, bool shorten = false)
    {
        _elementCodec = elementCodec;
        _shorten = shorten;
    }

    /// <summary>
    ///     Decodes a vector value from the buffer
    /// </summary>
    /// <param name="buffer">The buffer to decode from</param>
    /// <returns>The decoded vector value</returns>
    public override object? Decode(EByteArray buffer)
    {
        int length;
        if (_shorten && (bool)BoolCodec.Instance.Decode(buffer)) return null;

        length = (int)IntCodec.Instance.Decode(buffer);

        var result = new object?[length];
        for (int i = 0; i < length; i++) result[i] = _elementCodec.Decode(buffer);

        return result;
    }

    /// <summary>
    ///     Encodes a vector value to the buffer
    /// </summary>
    /// <param name="value">The vector value to encode</param>
    /// <param name="buffer">The buffer to encode to</param>
    /// <returns>The number of bytes written</returns>
    public override int Encode(object? value, EByteArray buffer)
    {
        int bytesWritten = 0;
        if (_shorten && value is null) return BoolCodec.Instance.Encode(true, buffer);

        if (value is null) throw new ArgumentNullException(nameof(value));
        if (value is not object?[] array) throw new ArgumentException("Value must be an object?[]", nameof(value));

        bytesWritten += IntCodec.Instance.Encode(array.Length, buffer);
        foreach (var item in array) bytesWritten += _elementCodec.Encode(item, buffer);

        return bytesWritten;
    }
}
