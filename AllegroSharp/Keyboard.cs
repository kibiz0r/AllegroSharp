using System;

namespace AllegroSharp
{
	public static class Keyboard
	{
		public static bool Install()
		{
			return Bridge.al_install_keyboard();
		}
		
		public static EventSource EventSource
		{
			get
			{
				var eventSource = Bridge.al_get_keyboard_event_source();
				if (eventSource != IntPtr.Zero)
				{
					return new EventSource(eventSource);
				}
				return null;
			}
		}
		
		public static KeyboardState GetState()
		{
			KeyboardState state = new KeyboardState();
			Bridge.al_get_keyboard_state(state);
			return state;
		}
	}
}
