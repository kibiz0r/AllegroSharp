using System;
using System.Collections;
using System.Runtime.InteropServices;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
	public static class Allegro
	{
		public static uint GetVersion()
		{
				return Allegro5.al_get_allegro_version();
		}
		
		public static void RunMain(Action main)
		{
            var args = Environment.GetCommandLineArgs();
            var argsPtr = Marshal.AllocHGlobal(IntPtr.Size * args.Length);
            var i = 0;
            foreach (var arg in args)
            {
                var argPtr = Marshal.StringToCoTaskMemAnsi(arg);
                Marshal.WriteIntPtr(argsPtr, i, argPtr);
            }
            AllegroMain mainWrapper = delegate(int argc, string[] argv)
            {
                try
                {
                    main();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return 0;
            };
            Allegro5.al_run_main(args.Length, argsPtr, mainWrapper);
		}
		
		public static bool InstallSystem()
		{
            return Allegro5.al_install_system(GetVersion(), IntPtr.Zero);
		}
		
		public static void Uninstall()
		{
			Allegro5.al_uninstall_system();
		}
	}
}
