using System;

namespace AllegroSharp
{
	public enum Key
	{
		A		= 1,
		B		= 2,
		C		= 3,
		D		= 4,
		E		= 5,
		F		= 6,
		G		= 7,
		H		= 8,
		I		= 9,
		J		= 10,
		K		= 11,
		L		= 12,
		M		= 13,
		N		= 14,
		O		= 15,
		P		= 16,
		Q		= 17,
		R		= 18,
		S		= 19,
		T		= 20,
		U		= 21,
		V		= 22,
		W		= 23,
		X		= 24,
		Y		= 25,
		Z		= 26,
	
		Num0		= 27,
		Num1		= 28,
		Num2		= 29,
		Num3		= 30,
		Num4		= 31,
		Num5		= 32,
		Num6		= 33,
		Num7		= 34,
		Num8		= 35,
		Num9		= 36,
	
		Pad0		= 37,
		Pad1		= 38,
		Pad2		= 39,
		Pad3		= 40,
		Pad4		= 41,
		Pad5		= 42,
		Pad6		= 43,
		Pad7		= 44,
		Pad8		= 45,
		Pad9		= 46,
	
		F1		= 47,
		F2		= 48,
		F3		= 49,
		F4		= 50,
		F5		= 51,
		F6		= 52,
		F7		= 53,
		F8		= 54,
		F9		= 55,
		F10		= 56,
		F11		= 57,
		F12		= 58,
	
		Escape	= 59,
		Tilde		= 60,
		Minus		= 61,
		Equals	= 62,
		Backspace	= 63,
		Tab		= 64,
		OpenBrace	= 65,
		CloseBrace	= 66,
		Enter		= 67,
		Semicolon	= 68,
		Quote		= 69,
		Backslash	= 70,
		Backslash2	= 71, /* DirectInput calls this DIK_OEM_102: "< > | on UK/Germany keyboards" */
		Comma		= 72,
		FullStop	= 73,
		Slash		= 74,
		Space		= 75,
	
		Insert	= 76,
		Delete	= 77,
		Home		= 78,
		End		= 79,
		PageUp		= 80,
		PageDown		= 81,
		Left		= 82,
		Right		= 83,
		Up		= 84,
		Down		= 85,
	
		PadSlash	= 86,
		PadAsterisk	= 87,
		PadMinus	= 88,
		PadPlus	= 89,
		PadDelete	= 90,
		PadEnter	= 91,
	
		PrintScreen	= 92,
		Pause		= 93,
	
		ABNT_C1	= 94,
		Yen		= 95,
		Kana		= 96,
		Convert	= 97,
		NoConvert	= 98,
		AT		= 99,
		Circumflex	= 100,
		Colon2	= 101,
		Kanji		= 102,
	
		EqualsPad	= 103,	/* MacOS X */
		BackQuote	= 104,	/* MacOS X */
		Semicolon2	= 105,	/* MacOS X -- TODO: ask lillo what this should be */
		Command	= 106,	/* MacOS X */
		Unknown		= 107,
	
		/* All codes up to before MODIFIERS can be freely
		 * assignedas additional unknown keys, like various multimedia
		 * and application keys keyboards may have.
		 */
	
		Modifiers	= 215,
	
		LShift	= 215,
		RShift	= 216,
		LCtrl	= 217,
		RCtrl	= 218,
		Alt		= 219,
		AltGR	= 220,
		LWin		= 221,
		RWin		= 222,
		Menu		= 223,
		ScrollLock = 224,
		NumLock	= 225,
		CapsLock	= 226
	}
}
