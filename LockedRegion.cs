using System;
using AllegroSharp.Bridge;

namespace AllegroSharp
{
    public sealed class LockedRegion : IDisposable
    {
        public IntPtr Ptr { get; set; }
        internal Bitmap Bitmap { get; set; }
        
        internal LockedRegion(IntPtr ptr, Bitmap bitmap)
        {
            this.Ptr = ptr;
            this.Bitmap = bitmap;
        }

        public void Dispose()
        {
            Allegro5.al_unlock_bitmap(Bitmap.Ptr);
        }
    }
}
