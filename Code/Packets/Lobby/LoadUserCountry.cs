using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads user country information, including available countries, default country code, and location check status.
/// </summary>
public class LoadUserCountry : AbstractPacket
{
    public static int Id { get; } = -1232334539;
    public override string Description => "Load user country information";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(CountryInfoCodec.Instance, false), // countries
        StringCodec.Instance, // defaultCountryCode
        BoolCodec.Instance // locationCheckEnabled
    };

    public override string[] Attributes => new[]
    {
        "countries",
        "defaultCountryCode",
        "locationCheckEnabled"
    };
}