using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
    public static class TtfAddon
    {
        public const string Dll = "allegro_ttf-5.dll";

        [DllImport(Dll)]
        public static extern bool al_init_ttf_addon();

        [DllImport(Dll)]
        public static extern IntPtr al_load_ttf_font(string filename, int size, TtfFlags flags);
    }
}
