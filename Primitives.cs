using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public static class Primitives
    {
        public static bool Init()
        {
            return PrimitivesAddon.al_init_primitives_addon();
        }
        
        public static void DrawLine(float x1, float y1, float x2, float y2, Color color, float thickness)
        {
            PrimitivesAddon.al_draw_line(x1, y1, x2, y2, color, thickness);
        }

        public static void DrawFilledCircle(float cx, float cy, float r, Color color)
        {
            PrimitivesAddon.al_draw_filled_circle(cx, cy, r, color);
        }

        public static void DrawRectangle(float x1, float y1, float x2, float y2, Color color, float thickness)
        {
            PrimitivesAddon.al_draw_rectangle(x1, y1, x2, y2, color, thickness);
        }

        public static void DrawFilledRectangle(float x1, float y1, float x2, float y2, Color color)
        {
            PrimitivesAddon.al_draw_filled_rectangle(x1, y1, x2, y2, color);
        }
        
        public static void DrawRibbon(float[] points, int pointsStride, Color color, float thickness, int numSegments)
        {
            PrimitivesAddon.al_draw_ribbon(points, pointsStride, color, thickness, numSegments);
        }
    }
}
