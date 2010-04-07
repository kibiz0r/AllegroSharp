using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int RealAllegroMain(int argc, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] string[] argv);
	
	public delegate void AllegroMain(string[] argv);
	
	public static class Allegro
	{
		public static string Version
		{
			get
			{
				var version = Bridge.al_get_version();
				return String.Format("{0}.{1}.{2}", version >> 24, (version >> 16) & 255, (version >> 8) & 255);
			}
		}
		
		public static void Main(AllegroMain main)
		{
			var args = Environment.GetCommandLineArgs();
			var argsPtr = Marshal.AllocHGlobal(IntPtr.Size * args.Length);
			var i = 0;
			foreach (var arg in args)
			{
				var argPtr = Marshal.StringToCoTaskMemAnsi(arg);
				Marshal.WriteIntPtr(argsPtr, i, argPtr);
			}
			Exception caught = null;
			RealAllegroMain mainWrapper = delegate(int argc, string[] argv)
			{
				try
				{
					main(argv);
				}
				catch (Exception ex)
				{
					caught = ex;
					return 1;
				}
				return 0;
			};
			Bridge.al_run_main(args.Length, argsPtr, mainWrapper);
			if (caught != null)
			{
				throw caught;
			}
		}
		
		public static void Install()
		{
			if (!Bridge.al_install_system(IntPtr.Zero))
			{
				throw new Exception("Failed to install Allegro");
			}
			if (!Bridge.al_init_image_addon())
			{
				throw new Exception("Failed to init Image I/O");
			}
		}
		
		public static void Uninstall()
		{
			Bridge.al_uninstall_system();
		}
	}
}
