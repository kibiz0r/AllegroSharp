using System;
using System.Runtime.InteropServices;

namespace AllegroSharp.Bridge
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int AllegroMain(int argc, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] string[] argv);
}
