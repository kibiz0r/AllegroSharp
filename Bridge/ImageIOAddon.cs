using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
    public static class ImageIOAddon
    {
        public const string Dll = "allegro_image-5.dll";

        [DllImport(Dll)]
        public static extern bool al_init_image_addon();

        [DllImport(Dll)]
        public static extern IntPtr al_load_bitmap(string filename);
        
        [DllImport(Dll)]
        public static extern IntPtr al_load_bmp(string filename);
        
        [DllImport(Dll)]
        public static extern IntPtr al_load_jpg(string filename);
        
        [DllImport(Dll)]
        public static extern IntPtr al_load_pcx(string filename);
        
        [DllImport(Dll)]
        public static extern IntPtr al_load_png(string filename);
        
        [DllImport(Dll)]
        public static extern IntPtr al_load_tga(string filename);
    }
}
