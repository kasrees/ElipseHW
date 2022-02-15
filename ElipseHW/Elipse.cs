using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElipseHW
{
    public class Elipse
    {
        public Point Center { get; private set; }
        public double A { get; private set; }
        public double B { get; private set; }

        public Elipse(Point center, double a, double b)
        {
            if (center == null) 
                throw new ArgumentNullException("Center argument can't be NULL.");
            if (a <= 0)
                throw new ArgumentException("A less or equal 0.");
            if (b <= 0)
                throw new ArgumentException("B less or equal 0.");
            
            Center = center;
            A = a;
            B = b;
        }

        public double GetSquare()
        {
            return Math.PI * A * B;
        }

        public double GetPerimeter()
        {
            return 4 * ((Math.PI * A * B) + Math.Pow((A - B), 2)) / (A + B);
        }

        public override string ToString()
        {
            return $"(A: {A}, B: {B}, Center: {Center})";
        }
    }
}
