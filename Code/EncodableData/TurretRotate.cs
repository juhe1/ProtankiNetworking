using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class TurretRotate : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public float Angle { get; set; }

    [Encode(1)]
    public byte Control { get; set; }

}