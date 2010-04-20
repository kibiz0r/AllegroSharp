using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
    public static class FontAddon
    {
        public const string Dll = "allegro_font-4.9.dll";

        [DllImport(Dll)]
        public static extern void al_init_font_addon();

        [DllImport(Dll)]
        public static extern void al_draw_text(IntPtr font, float x, float y, FontDrawFlags flags, string text);
    }
}
