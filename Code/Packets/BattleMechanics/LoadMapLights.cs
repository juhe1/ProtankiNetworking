using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Map Lights
/// </summary>
public class LoadMapLights : AbstractPacket
{
    public const int ID_CONST = -152638117;
    public override int Id => ID_CONST;
    public override string Description => "Load Map Lights";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}