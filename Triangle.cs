using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShape
{
    public class Triangle : AbstractShape
    {
        double a, b, c, p, hypotenuse, sidesOne, sidesTwo;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double ShapeArea()
        {
			if ((a == b) & (a == c))
			{
				p = ((a + b + c) / 2);
				return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			}
			else
			{
				hypotenuse = Math.Max(Math.Max(a, b), c);
				sidesOne = Math.Min(a, b);
				sidesTwo = Math.Min(sidesOne, c);

				if (Math.Pow(hypotenuse, 2) == (Math.Pow(sidesOne, 2) + (Math.Pow(sidesTwo, 2))))
				{
					return 0.5 * (sidesOne * sidesTwo);

				}
				else
				{
					p = ((a + b + c) / 2);
					return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
				}
			}
		}
    }
}
