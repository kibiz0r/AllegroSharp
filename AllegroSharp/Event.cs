using System;
using AllegroSharp.Bridge;
using System.Runtime.InteropServices;

namespace AllegroSharp
{
    public struct Event
    {
        public EventType Type;
        public IntPtr Source;
        public double TimeStamp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public IntPtr[] Data;
    }
}

