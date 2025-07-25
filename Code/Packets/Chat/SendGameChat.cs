

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Sends a message to the game chat
/// </summary>
public class SendGameChat : Packet
{
    [Encode(0)]
    public string? Message { get; set; }

    [Encode(1)]
    public bool TeamOnly { get; set; }

    public const int ID_CONST = 945463181;
    public override int Id => ID_CONST;
    public override string Description => "Sends a message to the game chat";


}