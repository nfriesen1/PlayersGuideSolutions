using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch._24.Models
{
    public class Color
    {
        private int r;
        private int g;
        private int b;

        public int R
        {
            get { return r; }
            set
            {
                r = ValidateColorValue(value, nameof(R));
            }
        }

        public int G
        {
            get { return g; }
            set
            {
                g = ValidateColorValue(value, nameof(G));
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                b = ValidateColorValue(value, nameof(B));
            }
        }

        public static Color White => new Color(255, 255, 255);
        public static Color Black => new Color(0, 0, 0);
        public static Color Red => new Color(255, 0, 0);
        public static Color Orange => new Color(255, 165, 0);
        public static Color Yellow => new Color(255, 255, 0);
        public static Color Green => new Color(0, 128, 0);
        public static Color Blue => new Color(0, 0, 255);
        public static Color Purple => new Color(128, 0, 128);

        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string ToString()
        {
            return $"(R: {R}, G: {G}, B: {B})";
        }

        private static int ValidateColorValue(int value, string propertyName)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException(propertyName, "Value must be between 0 and 255.");
            return value;
        }

    }
}
