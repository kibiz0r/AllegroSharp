using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public class Font
    {
        public readonly IntPtr Ptr;

        public Font(IntPtr ptr)
        {
            this.Ptr = ptr;
        }

        public void Draw(float x, float y, FontDrawFlags flags, string text)
        {
            FontAddon.al_draw_text(Ptr, x, y, flags, text);
        }

        public static void Init()
        {
            FontAddon.al_init_font_addon();
        }
    }
}
