using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public static class Blender
	{
		public static void Get(out BlenderFunction source, out BlenderFunction destination, out Color color)
		{
			Allegro5.al_get_blender(out source, out destination, out color);
		}
		
		public static void Set(BlenderFunction source, BlenderFunction destination, Color color)
		{
			Allegro5.al_set_blender(source, destination, color);
		}
	}
}
