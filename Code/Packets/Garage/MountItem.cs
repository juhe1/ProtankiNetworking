using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Mount an item in garage
/// </summary>
public class MountItem : AbstractPacket
{
    public static int IdStatic { get; } = -1505530736;
    public override int Id => IdStatic;
    public override string Description => "Mount an item in garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "item_id"
    };
}