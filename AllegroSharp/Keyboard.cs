using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public static class Keyboard
	{
		public static bool Install()
		{
			return Allegro5.al_install_keyboard();
		}
		
		public static EventSource GetEventSource()
		{
			var eventSource = Allegro5.al_get_keyboard_event_source();
			if (eventSource != IntPtr.Zero)
			{
				return new EventSource(eventSource);
			}
			return null;
		}
		
		public static void GetState(ref KeyboardState state)
		{
			Allegro5.al_get_keyboard_state(ref state);
		}
	}
}
