using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public static class Image
    {
        public static bool Init()
        {
            return ImageIOAddon.al_init_image_addon();
        }

        public static Bitmap LoadBitmap(string filename)
        {
            var bitmap = ImageIOAddon.al_load_bitmap(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
        
        public static Bitmap LoadBmp(string filename)
        {
            var bitmap = ImageIOAddon.al_load_bmp(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
        
        public static Bitmap LoadJpg(string filename)
        {
            var bitmap = ImageIOAddon.al_load_jpg(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
        
        public static Bitmap LoadPcx(string filename)
        {
            var bitmap = ImageIOAddon.al_load_pcx(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
        
        public static Bitmap LoadPng(string filename)
        {
            var bitmap = ImageIOAddon.al_load_png(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
        
        public static Bitmap LoadTga(string filename)
        {
            var bitmap = ImageIOAddon.al_load_tga(filename);
            if (bitmap == IntPtr.Zero)
            {
                return null;
            }
            return new Bitmap(bitmap);
        }
    }
}
