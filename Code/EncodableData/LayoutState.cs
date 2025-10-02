namespace ProtankiNetworking.EncodableData;

public enum LayoutState
{
	BATTLE_SELECT = 0,
	GARAGE = 1,
	PAYMENT = 2,
	BATTLE = 3,
	RELOAD_SPACE = 4,
	NULL = 5, // Server or client will newer send this. It is just to have initial value. 
}
