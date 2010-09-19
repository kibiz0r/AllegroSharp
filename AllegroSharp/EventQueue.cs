using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public class EventQueue
    {
        public static EventQueue Create()
        {
            return new EventQueue(Allegro5.al_create_event_queue());
        }

        internal EventQueue(IntPtr ptr)
        {
            Ptr = ptr;
        }

        internal IntPtr Ptr = IntPtr.Zero;

        public void RegisterEventSource(EventSource eventSource)
        {
            Allegro5.al_register_event_source(Ptr, eventSource.Ptr);
        }

        public bool GetNextEvent(ref Event @event)
        {
            return Allegro5.al_get_next_event(Ptr, ref @event);
        }
    }
}

