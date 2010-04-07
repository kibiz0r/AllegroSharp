using System;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	internal static partial class Bridge
	{
		[DllImport(Allegro)]
		public static extern bool al_install_keyboard();
		
		[DllImport(Allegro)]
		public static extern IntPtr al_get_keyboard_event_source();
		
		[DllImport(Allegro)]
		public static extern void al_get_keyboard_state([Out] KeyboardState state);
		
		[DllImport(Allegro)]
		public static extern bool al_key_down(KeyboardState state, Key keyCode);
	}
}
