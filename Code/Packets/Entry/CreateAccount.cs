

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Create new account
/// </summary>
public class CreateAccount : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    [Encode(1)]
    public string? Password { get; set; }

    [Encode(2)]
    public bool RememberMe { get; set; }

    public const int ID_CONST = 427083290;
    public override int Id => ID_CONST;
    public override string Description => "Create new account";


}