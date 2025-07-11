using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Railgun start charging event.
/// </summary>
public class RailgunStartChargingIn : AbstractPacket
{
    public const int ID_CONST = 346830254;
    public override int Id => ID_CONST;
    public override string Description => "Send Railgun start charging event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };

    public override string[] Attributes => new[]
    {
        "userId"
    };
}