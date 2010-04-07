using System;

namespace AllegroSharp
{
	public class Bitmap : IDisposable
	{
		public int Width
		{
			get
			{
				return Bridge.al_get_bitmap_width(Ptr);
			}
		}
		
		public int Height
		{
			get
			{
				return Bridge.al_get_bitmap_height(Ptr);
			}
		}
		
		public static Bitmap Load(string filename)
		{
			var bitmap = Bridge.al_load_bitmap(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public static Bitmap LoadBmp(string filename)
		{
			var bitmap = Bridge.al_load_bmp(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public static Bitmap LoadJpg(string filename)
		{
			var bitmap = Bridge.al_load_jpg(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public static Bitmap LoadPcx(string filename)
		{
			var bitmap = Bridge.al_load_pcx(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public static Bitmap LoadPng(string filename)
		{
			var bitmap = Bridge.al_load_png(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public static Bitmap LoadTga(string filename)
		{
			var bitmap = Bridge.al_load_tga(filename);
			if (bitmap == IntPtr.Zero)
			{
				throw new Exception(String.Format("Failed to load bitmap {0}", filename));
			}
			return new Bitmap(bitmap);
		}
		
		public void Draw(float dx, float dy, int flags)
		{
			Bridge.al_draw_bitmap(Ptr, dx, dy, flags);
		}
		
		internal Bitmap(IntPtr ptr)
		{
			Ptr = ptr;
		}
		
		public void Dispose()
		{
			if (Ptr != IntPtr.Zero)
			{
				Bridge.al_destroy_bitmap(Ptr);
				Ptr = IntPtr.Zero;
			}
		}
		
		internal IntPtr Ptr = IntPtr.Zero;
	}
}
