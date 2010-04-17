using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public class Bitmap : IDisposable
	{
        public readonly IntPtr Ptr;
        public readonly int Width;
        public readonly int Height;

        public Bitmap(IntPtr ptr)
        {
            this.Ptr = ptr;
            this.Width = Allegro5.al_get_bitmap_width(Ptr);
            this.Height = Allegro5.al_get_bitmap_height(Ptr);
        }

        ~Bitmap()
        {
            Dispose();
        }

        public void Dispose()
        {
            Allegro5.al_destroy_bitmap(Ptr);
        }

		public void Draw(float dx, float dy, DrawFlags flags)
		{
			Allegro5.al_draw_bitmap(Ptr, dx, dy, flags);
		}

        public void DrawPixel(float x, float y, Color color)
        {
            Allegro5.al_draw_pixel(x, y, color);
        }

        public Color GetPixel(int x, int y)
        {
            return Allegro5.al_get_pixel(Ptr, x, y);
        }
		
        public LockedRegion Lock(PixelFormat format, LockFlags flags)
        {
            var ptr = Allegro5.al_lock_bitmap(Ptr, format, flags);
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            return new LockedRegion(ptr, this);
        }
	}
}
