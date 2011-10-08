using System;

namespace AllegroSharp
{
	public struct Color
	{
		public Color(float red, float green, float blue, float alpha)
		{
			Red = red;
			Green = green;
			Blue = blue;
			Alpha = alpha;
		}
		
		public Color(float red, float green, float blue)
		: this(red, green, blue, 1f)
		{
		}
		
		public float Red;
		public float Green;
		public float Blue;
		public float Alpha;

        public static bool operator==(Color c1, Color c2)
        {
            return c1.Red == c2.Red && c1.Green == c2.Green && c1.Blue == c2.Blue && c1.Alpha == c2.Alpha;
        }

        public static bool operator!=(Color c1, Color c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                Color color = (Color)obj;
                return this == color;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Red.GetHashCode() ^ Green.GetHashCode() ^ Blue.GetHashCode() ^ Alpha.GetHashCode();
        }
	}
}
