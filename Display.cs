using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public sealed class Display : IDisposable
	{
		public static Display Create(int width, int height)
		{
			var display = Allegro5.al_create_display(width, height);
			if (display == IntPtr.Zero)
			{
				return null;
			}
			return new Display(display);
		}
		
		public static int Flags
		{
			get
			{
				return Allegro5.al_get_display_flags();
			}
		}
		
		public static void SetNewOption(int option, int value, int importance)
		{
			Allegro5.al_set_new_display_option(option, value, importance);
		}
		
		public static int GetOption(int option)
		{
			return Allegro5.al_get_display_option(option);
		}
		
		public static void Clear(Color color)
		{
			Allegro5.al_clear_to_color(color);
		}
		
		public static Display Current
		{
			get
			{
				var display = Allegro5.al_get_current_display();
				if (display != IntPtr.Zero)
				{
					return new Display(display);
				}
				return null;
			}
			set
			{
				SetCurrent(value);
			}
		}
		
		public static bool SetCurrent(Display display)
		{
			if (display == null)
			{
				return Allegro5.al_set_current_display(IntPtr.Zero);
			}
			else
			{
				return Allegro5.al_set_current_display(display.Ptr);
			}
		}
		
		public static Bitmap Icon
		{
			set
			{
				if (value == null)
				{
					Allegro5.al_set_display_icon(IntPtr.Zero);
				}
				else
				{
					Allegro5.al_set_display_icon(value.Ptr);
				}
			}
		}
		
		public static void Flip()
		{
			Allegro5.al_flip_display();
		}
		
		public bool AcknowledgeResize()
		{
			return Allegro5.al_acknowledge_resize(Ptr);
		}
		
		public static Bitmap FrontBuffer
		{
			get
			{
				var bitmap = Allegro5.al_get_frontbuffer();
				if (bitmap != IntPtr.Zero)
				{
					return new Bitmap(bitmap);
				}
				return null;
			}
		}
		
		public static Bitmap BackBuffer
		{
			get
			{
				var bitmap = Allegro5.al_get_backbuffer();
				if (bitmap != IntPtr.Zero)
				{
					return new Bitmap(bitmap);
				}
				return null;
			}
		}
		
		public static int Height
		{
			get
			{
				return Allegro5.al_get_display_height();
			}
		}
		
		public static int Width
		{
			get
			{
				return Allegro5.al_get_display_width();
			}
		}
		
		public void GetWindowPosition(out int x, out int y)
		{
			Allegro5.al_get_window_position(Ptr, out x, out y);
		}
		
		public static bool InhibitScreensaver(bool inhibit)
		{
			return Allegro5.al_inhibit_screensaver(inhibit);
		}
		
		public static bool Resize(int width, int height)
		{
			return Allegro5.al_resize_display(width, height);
		}
		
		public static string Title
		{
			set
			{
				Allegro5.al_set_window_title(value);
			}
		}
		
		public static bool WaitForVSync()
		{
			return Allegro5.al_wait_for_vsync();
		}
		
		public EventSource EventSource
		{
			get
			{
				var eventSource = Allegro5.al_get_display_event_source(Ptr);
				if (eventSource != IntPtr.Zero)
				{
					return new EventSource(eventSource);
				}
				return null;
			}
		}
		
		internal Display(IntPtr ptr)
		{
			Ptr = ptr;
		}
		
		public void Dispose()
		{
			if (Ptr != IntPtr.Zero)
			{
				Allegro5.al_destroy_display(Ptr);
				Ptr = IntPtr.Zero;
			}
		}
		
		internal IntPtr Ptr = IntPtr.Zero;
	}
}
