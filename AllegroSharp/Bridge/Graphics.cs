using System;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	internal static partial class Bridge
	{
		[DllImport(Allegro)]
		public static extern void al_destroy_bitmap(IntPtr bitmap);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_bitmap(string filename);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_bmp(string filename);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_jpg(string filename);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_pcx(string filename);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_png(string filename);
		
		[DllImport(ImageIO)]
		public static extern IntPtr al_load_tga(string filename);
		
		[DllImport(Allegro)]
		public static extern void al_draw_bitmap(IntPtr bitmap, float dx, float dy, int flags);
		
		[DllImport(Allegro)]
		public static extern void al_clear_to_color(Color color);
		
		[DllImport(Allegro)]
		public static extern int al_get_bitmap_width(IntPtr bitmap);
		
		[DllImport(Allegro)]
		public static extern int al_get_bitmap_height(IntPtr bitmap);
		
		[DllImport(Allegro)]
		public static extern void al_get_blender(out BlenderFunction src, out BlenderFunction dst, out Color color);
		
		[DllImport(Allegro)]
		public static extern void al_set_blender(BlenderFunction src, BlenderFunction dst, Color color);
	}
}
