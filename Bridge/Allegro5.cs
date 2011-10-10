using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
	public static class Allegro5
	{
		public const string Dll = "allegro-5.dll";

        public const int ALLEGRO_KEY_MAX = 8;
		
		[DllImport(Dll)]
		public static extern uint al_get_allegro_version();
		
		[DllImport(Dll)]
		public static extern bool al_install_system(uint version, IntPtr at_exit);
		
		[DllImport(Dll)]
		public static extern void al_uninstall_system();
		
		[DllImport(Dll)]
		public static extern int al_run_main(int argc, IntPtr argv, AllegroMain main);

        [DllImport(Dll)]
        public static extern void al_destroy_bitmap(IntPtr bitmap);

        [DllImport(Dll)]
        public static extern Color al_get_pixel(IntPtr bitmap, int x, int y);

        [DllImport(Dll)]
        public static extern IntPtr al_lock_bitmap(IntPtr bitmap, PixelFormat format, LockFlags flags);

        [DllImport(Dll)]
        public static extern void al_unlock_bitmap(IntPtr bitmap);

        [DllImport(Dll)]
        public static extern void al_draw_pixel(float x, float y, Color color);

        [DllImport(Dll)]
        public static extern void al_draw_bitmap(IntPtr bitmap, float dx, float dy, DrawFlags flags);
        
        [DllImport(Dll)]
        public static extern void al_clear_to_color(Color color);

        [DllImport(Dll)]
        public static extern int al_get_bitmap_width(IntPtr bitmap);
        
        [DllImport(Dll)]
        public static extern int al_get_bitmap_height(IntPtr bitmap);
        
        [DllImport(Dll)]
        public static extern void al_get_blender(out BlendOperation op, out BlendMode src, out BlendMode dst, out Color color);
        
        [DllImport(Dll)]
        public static extern void al_set_blender(BlendOperation op, BlendMode src, BlendMode dst, Color color);

        [DllImport(Dll)]
        public static extern IntPtr al_create_display(int w, int h);
        
        [DllImport(Dll)]
        public static extern void al_destroy_display(IntPtr display);
        
        [DllImport(Dll)]
        public static extern void al_flip_display();

        [DllImport(Dll)]
        public static extern bool al_acknowledge_resize(IntPtr display);
        
        [DllImport(Dll)]
        public static extern IntPtr al_get_frontbuffer();
        
        [DllImport(Dll)]
        public static extern IntPtr al_get_backbuffer();
        
        [DllImport(Dll)]
        public static extern IntPtr al_get_current_display();
        
        [DllImport(Dll)]
        public static extern int al_get_display_height(IntPtr display);
        
        [DllImport(Dll)]
        public static extern int al_get_display_width(IntPtr display);
        
        [DllImport(Dll)]
        public static extern void al_get_window_position(IntPtr display, out int x, out int y);
        
        [DllImport(Dll)]
        public static extern bool al_inhibit_screensaver(bool inhibit);
        
        [DllImport(Dll)]
        public static extern bool al_resize_display(int width, int height);
        
        [DllImport(Dll)]
        public static extern bool al_set_current_display(IntPtr display);
        
        [DllImport(Dll)]
        public static extern void al_set_display_icon(IntPtr icon);
        
        [DllImport(Dll)]
        public static extern void al_set_window_title(string title);
        
        [DllImport(Dll)]
        public static extern bool al_wait_for_vsync();
        
        [DllImport(Dll)]
        public static extern IntPtr al_get_display_event_source(IntPtr display);
        
        [DllImport(Dll)]
        public static extern int al_get_display_flags();
        
        [DllImport(Dll)]
        public static extern int al_get_display_option(int option);
        
        [DllImport(Dll)]
        public static extern void al_set_new_display_option(int option, int value, int importance);

        [DllImport(Dll)]
        public static extern bool al_install_keyboard();
        
        [DllImport(Dll)]
        public static extern IntPtr al_get_keyboard_event_source();
        
        [DllImport(Dll)]
        public static extern void al_get_keyboard_state(ref KeyboardState state);
        
        [DllImport(Dll)]
        public static extern bool al_key_down(ref KeyboardState state, Key keyCode);

        [DllImport(Dll)]
        public static extern IntPtr al_create_event_queue();

        [DllImport(Dll)]
        public static extern void al_register_event_source(IntPtr eventQueue, IntPtr eventSource);

        [DllImport(Dll)]
        public static extern IntPtr al_create_event();

        [DllImport(Dll)]
        public static extern bool al_get_next_event(IntPtr eventSource, ref Event @event);
	}
}
