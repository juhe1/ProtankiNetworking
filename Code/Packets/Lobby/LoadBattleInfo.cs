using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads detailed battle information
/// </summary>
public class LoadBattleInfo : AbstractPacket
{
    public static int IdStatic { get; } = 546722394;
    public override int Id => IdStatic;
    public override string Description => "Loads detailed battle information";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}