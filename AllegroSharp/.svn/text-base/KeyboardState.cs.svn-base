using System;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	[StructLayout(LayoutKind.Sequential)]
	public sealed class KeyboardState
	{
		public bool KeyDown(Key key)
		{
			return Bridge.al_key_down(this, key);
		}
		
		public Display Display
		{
			get
			{
				if (display == IntPtr.Zero)
				{
					return null;
				}
				return new Display(display);
			}
		}
		private IntPtr display = IntPtr.Zero;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Bridge.ALLEGRO_KEY_MAX)]
		private uint[] data = new uint[Bridge.ALLEGRO_KEY_MAX];
	}
}
