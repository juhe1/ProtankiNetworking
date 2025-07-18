namespace ProtankiNetworking.Security;

/// <summary>
///     Handles encryption and decryption of packet data using a custom XOR-based scheme
/// </summary>
public class Protection
{
    private const int VECTOR_LEN = 8;
    private readonly byte[] _decryptionVector;
    private readonly byte[] _encryptionVector;
    private readonly bool _flipDirection;
    private bool _active;
    private byte _base;
    private int _decryptionIndex;
    private int _encryptionIndex;

    /// <summary>
    ///     Creates a new instance of Protection
    /// </summary>
    /// <param name="flipDirection">Whether to flip the encryption/decryption roles</param>
    public Protection(bool flipDirection = false)
    {
        _active = false;
        _flipDirection = flipDirection;
        _base = 0;
        _decryptionVector = new byte[VECTOR_LEN];
        _encryptionVector = new byte[VECTOR_LEN];
        _decryptionIndex = 0;
        _encryptionIndex = 0;
    }

    /// <summary>
    ///     Activates protection using a list of keys
    /// </summary>
    /// <param name="keys">List of keys to use for encryption/decryption</param>
    public void Activate(byte[] keys)
    {
        foreach (var key in keys) _base ^= (byte)(key & 0xFF);

        for (int i = 0; i < VECTOR_LEN; i++)
        {
            byte baseXor = (byte)(_base ^ (i << 3));
            if (!_flipDirection)
            {
                _decryptionVector[i] = baseXor;
                _encryptionVector[i] = (byte)(baseXor ^ 0x57);
            }
            else
            {
                _decryptionVector[i] = (byte)(baseXor ^ 0x57);
                _encryptionVector[i] = baseXor;
            }
        }

        _active = true;
    }

    /// <summary>
    ///     Decrypts the specified data
    /// </summary>
    /// <param name="encryptedData">The data to decrypt</param>
    /// <returns>The decrypted data</returns>
    public byte[] Decrypt(byte[] encryptedData)
    {
        if (!_active)
            return encryptedData;

        var data = new byte[encryptedData.Length];
        Array.Copy(encryptedData, data, encryptedData.Length);

        for (int i = 0; i < data.Length; i++)
        {
            byte encryptedByte = data[i];
            byte decVal = _decryptionVector[_decryptionIndex] =
                data[i] = (byte)(encryptedByte ^ _decryptionVector[_decryptionIndex]);
            _decryptionIndex ^= decVal & 7;
        }

        return data;
    }

    /// <summary>
    ///     Encrypts the specified data
    /// </summary>
    /// <param name="rawData">The data to encrypt</param>
    /// <returns>The encrypted data</returns>
    public byte[] Encrypt(byte[] rawData)
    {
        if (!_active)
            return rawData;

        var encryptedData = new byte[rawData.Length];
        Array.Copy(rawData, encryptedData, rawData.Length);

        for (int i = 0; i < encryptedData.Length; i++)
        {
            byte rawByte = rawData[i];
            encryptedData[i] = (byte)(rawByte ^ _encryptionVector[_encryptionIndex]);
            _encryptionVector[_encryptionIndex] = rawByte;
            _encryptionIndex ^= rawByte & 7;
        }

        return encryptedData;
    }
}