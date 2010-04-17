using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public static class Blender
	{
		public static void Get(out BlendOperation operation, out BlendMode source, out BlendMode destination, out Color color)
		{
			Allegro5.al_get_blender(out operation, out source, out destination, out color);
		}
		
		public static void Set(BlendOperation operation, BlendMode source, BlendMode destination, Color color)
		{
			Allegro5.al_set_blender(operation, source, destination, color);
		}
	}
}
