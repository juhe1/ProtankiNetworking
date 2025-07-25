using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads user country information, including available countries, default country code, and location check status.
/// </summary>
public class LoadUserCountry : Packet
{
	[Encode(0)]
	public CountryInfo?[]? Countries { get; set; }

	[Encode(1)]
	public string? DefaultCountryCode { get; set; }

	[Encode(2)]
	public bool LocationCheckEnabled { get; set; }

	public const int ID_CONST = -1232334539;
	public override int Id => ID_CONST;
	public override string Description => "Load user country information";
}
