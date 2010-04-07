using System;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	internal static partial class Bridge
	{
		[DllImport(Allegro)]
		public static extern IntPtr al_create_display(int w, int h);
		
		[DllImport(Allegro)]
		public static extern void al_destroy_display(IntPtr display);
		
		[DllImport(Allegro)]
		public static extern void al_flip_display();
		
		[DllImport(Allegro)]
		public static extern bool al_acknowledge_resize(IntPtr display);
		
		[DllImport(Allegro)]
		public static extern IntPtr al_get_frontbuffer();
		
		[DllImport(Allegro)]
		public static extern IntPtr al_get_backbuffer();
		
		[DllImport(Allegro)]
		public static extern IntPtr al_get_current_display();
		
		[DllImport(Allegro)]
		public static extern int al_get_display_height();
		
		[DllImport(Allegro)]
		public static extern int al_get_display_width();
		
		[DllImport(Allegro)]
		public static extern void al_get_window_position(IntPtr display, out int x, out int y);
		
		[DllImport(Allegro)]
		public static extern bool al_inhibit_screensaver(bool inhibit);
		
		[DllImport(Allegro)]
		public static extern bool al_resize_display(int width, int height);
		
		[DllImport(Allegro)]
		public static extern bool al_set_current_display(IntPtr display);
		
		[DllImport(Allegro)]
		public static extern void al_set_display_icon(IntPtr icon);
		
		[DllImport(Allegro)]
		public static extern void al_set_window_title(string title);
		
		[DllImport(Allegro)]
		public static extern bool al_wait_for_vsync();
		
		[DllImport(Allegro)]
		public static extern IntPtr al_get_display_event_source(IntPtr display);
		
		[DllImport(Allegro)]
		public static extern int al_get_display_flags();
		
		[DllImport(Allegro)]
		public static extern int al_get_display_option(int option);
		
		[DllImport(Allegro)]
		public static extern void al_set_new_display_option(int option, int value, int importance);
	}
}
