using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public static class Ttf
    {
        public static bool Init()
        {
            return TtfAddon.al_init_ttf_addon();
        }

        public static Font LoadFont(string filename, int size, TtfFlags flags)
        {
            var font = TtfAddon.al_load_ttf_font(filename, size, flags);
            if (font == IntPtr.Zero)
            {
                return null;
            }
            return new Font(font);
        }
    }
}
