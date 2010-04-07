using System;

namespace AllegroSharp
{
	public sealed class Display : IDisposable
	{
		public static Display Create(int width, int height)
		{
			var display = Bridge.al_create_display(width, height);
			if (display != IntPtr.Zero)
			{
				return new Display(display);
			}
			throw new Exception("Failed to create display");
		}
		
		public static int Flags
		{
			get
			{
				return Bridge.al_get_display_flags();
			}
		}
		
		public static void SetNewOption(int option, int value, int importance)
		{
			Bridge.al_set_new_display_option(option, value, importance);
		}
		
		public static int GetOption(int option)
		{
			return Bridge.al_get_display_option(option);
		}
		
		public static void Clear(Color color)
		{
			Bridge.al_clear_to_color(color);
		}
		
		public static Display Current
		{
			get
			{
				var display = Bridge.al_get_current_display();
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
				return Bridge.al_set_current_display(IntPtr.Zero);
			}
			else
			{
				return Bridge.al_set_current_display(display.Ptr);
			}
		}
		
		public static Bitmap Icon
		{
			set
			{
				if (value == null)
				{
					Bridge.al_set_display_icon(IntPtr.Zero);
				}
				else
				{
					Bridge.al_set_display_icon(value.Ptr);
				}
			}
		}
		
		public static void Flip()
		{
			Bridge.al_flip_display();
		}
		
		public bool AcknowledgeResize()
		{
			return Bridge.al_acknowledge_resize(Ptr);
		}
		
		public static Bitmap FrontBuffer
		{
			get
			{
				var bitmap = Bridge.al_get_frontbuffer();
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
				var bitmap = Bridge.al_get_backbuffer();
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
				return Bridge.al_get_display_height();
			}
		}
		
		public static int Width
		{
			get
			{
				return Bridge.al_get_display_width();
			}
		}
		
		public void GetWindowPosition(out int x, out int y)
		{
			Bridge.al_get_window_position(Ptr, out x, out y);
		}
		
		public static bool InhibitScreensaver(bool inhibit)
		{
			return Bridge.al_inhibit_screensaver(inhibit);
		}
		
		public static bool Resize(int width, int height)
		{
			return Bridge.al_resize_display(width, height);
		}
		
		public static string Title
		{
			set
			{
				Bridge.al_set_window_title(value);
			}
		}
		
		public static bool WaitForVSync()
		{
			return Bridge.al_wait_for_vsync();
		}
		
		public EventSource EventSource
		{
			get
			{
				var eventSource = Bridge.al_get_display_event_source(Ptr);
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
				Bridge.al_destroy_display(Ptr);
				Ptr = IntPtr.Zero;
			}
		}
		
		internal IntPtr Ptr = IntPtr.Zero;
	}
}
