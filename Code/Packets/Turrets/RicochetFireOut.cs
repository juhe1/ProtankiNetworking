

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet fire out (time, shotId, shotDirectionX, shotDirectionY, shotDirectionZ).
/// </summary>
public class RicochetFireOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public int ShotId { get; set; }

    [Encode(2)]
    public short ShotDirectionX { get; set; }

    [Encode(3)]
    public short ShotDirectionY { get; set; }

    [Encode(4)]
    public short ShotDirectionZ { get; set; }

    public const int ID_CONST = -1907971330;

    public override string Description =>
        "Ricochet fire out (time, shotId, shotDirectionX, shotDirectionY, shotDirectionZ)";


}