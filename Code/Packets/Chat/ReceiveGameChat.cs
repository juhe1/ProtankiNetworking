

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Receives a message from the game chat
/// </summary>
public class ReceiveGameChat : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    [Encode(1)]
    public string? Message { get; set; }

    [Encode(2)]
    public int Team { get; set; }

    public const int ID_CONST = 1259981343;
    public override int Id => ID_CONST;
    public override string Description => "Receives a message from the game chat";


}