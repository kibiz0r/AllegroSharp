using System;
using System.Runtime.InteropServices;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public struct KeyboardState
	{
		public bool KeyDown(Key key)
		{
			return Allegro5.al_key_down(ref this, key);
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
#pragma warning disable 0649
		private readonly IntPtr display;
#pragma warning restore 0649
#pragma warning disable 0169
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Allegro5.ALLEGRO_KEY_MAX)]
		private readonly uint[] data;
#pragma warning restore 0169
	}
}
