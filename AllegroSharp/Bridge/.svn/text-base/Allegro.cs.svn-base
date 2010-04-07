using System;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	internal static partial class Bridge
	{
		public const string Allegro = "allegro-4.9.17.dll";
		public const string ImageIO = "allegro_image-4.9.17.dll";
		
		public const int ALLEGRO_KEY_MAX = 8;
		
		[DllImport(Allegro)]
		public static extern uint al_get_version();
		
		[DllImport(Allegro)]
		public static extern bool al_install_system(IntPtr atExit);
		
		[DllImport(ImageIO)]
		public static extern bool al_init_image_addon();
		
		[DllImport(Allegro)]
		public static extern void al_uninstall_system();
		
		[DllImport(Allegro)]
		public static extern int al_run_main(int argc, IntPtr argv, RealAllegroMain main);
	}
}
