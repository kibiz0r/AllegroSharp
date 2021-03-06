using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
    public static class PrimitivesAddon
    {
        public const string Dll = "allegro_primitives-5.dll";

        [DllImport(Dll)]
        public static extern bool al_init_primitives_addon();

        [DllImport(Dll)]
        public static extern void al_draw_line(float x1, float y1, float x2, float y2, Color color, float thickness);

        [DllImport(Dll)]
        public static extern void al_draw_rectangle(float x1, float y1, float x2, float y2, Color color, float thickness);

        [DllImport(Dll)]
        public static extern void al_draw_filled_rectangle(float x1, float y1, float x2, float y2, Color color);
        
        [DllImport(Dll)]
        public static extern void al_draw_circle(float cx, float cy, float r, Color color, float thickness);

        [DllImport(Dll)]
        public static extern void al_draw_filled_circle(float cx, float cy, float r, Color color);

        [DllImport(Dll)]
        public static extern void al_draw_ribbon(float[] points, int points_stride, Color color, float thickness, int num_segments);
    }
}
