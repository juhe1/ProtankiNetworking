using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class CaptureTheFlagSoundFX : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public int FlagDropSound { get; set; }

    [Encode(1)]
    public int FlagReturnSound { get; set; }

    [Encode(2)]
    public int FlagTakeSound { get; set; }

    [Encode(3)]
    public int WinSound { get; set; }

}