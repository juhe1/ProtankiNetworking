using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Syncs turret data to the client
/// </summary>
public class SyncTurretData : AbstractPacket
{
    public const int ID_CONST = -2124388778;
    public override int Id => ID_CONST;
    public override string Description => "Syncs turret data to the client";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}