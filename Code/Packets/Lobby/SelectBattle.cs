using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client selects a battle / Server confirms selection of battle
/// </summary>
public class SelectBattle : AbstractPacket
{
    public static int IdStatic { get; } = 2092412133;
    public override int Id => IdStatic;
    public override string Description => "Client selects a battle / Server confirms selection of battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID"
    };
}