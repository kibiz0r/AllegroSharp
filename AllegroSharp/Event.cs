using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public class Event
    {
        public static Event Create()
        {
            return new Event(Allegro5.al_create_event());
        }

        internal Event(IntPtr ptr)
        {
            Ptr = ptr;
        }

        internal IntPtr Ptr = IntPtr.Zero;
    }
}

