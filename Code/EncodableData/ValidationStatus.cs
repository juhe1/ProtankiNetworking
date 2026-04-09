namespace ProtankiNetworking.EncodableData;

public enum ValidationStatus
{
	TOO_SHORT = 0,
	TOO_LONG = 1,
	NOT_UNIQUE = 2,
	NOT_MATCH_PATTERN = 3,
	FORBIDDEN = 4,
	CORRECT = 5,
}