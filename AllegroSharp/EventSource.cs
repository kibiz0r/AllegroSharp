using System;

namespace AllegroSharp
{
	public sealed class EventSource
	{
		internal EventSource(IntPtr ptr)
		{
			Ptr = ptr;
		}
		
		internal IntPtr Ptr = IntPtr.Zero;
	}
}
