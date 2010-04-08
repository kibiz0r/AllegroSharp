using System;

namespace AllegroSharp
{
    public sealed class LockedRegion
    {
        public IntPtr Ptr { get; set; }
        
        public LockedRegion()
        {
        }

        public LockedRegion(IntPtr ptr)
        {
            this.Ptr = ptr;
        }
    }
}
