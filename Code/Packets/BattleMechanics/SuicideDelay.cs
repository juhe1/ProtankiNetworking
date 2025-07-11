using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Suicide delay packet
/// </summary>
public class SuicideDelay : AbstractPacket
{
    public const int IdStatic = -911983090;
    public override int Id => IdStatic;
    public override string Description => "Suicide delay packet";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "suicideDelayMS"
    };
}