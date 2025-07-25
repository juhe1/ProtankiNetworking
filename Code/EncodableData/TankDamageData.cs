using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class TankDamageData : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public float Damage { get; set; }

    [Encode(1)]
    public int DamageType { get; set; }

    [Encode(2)]
    public string? Target { get; set; }

}