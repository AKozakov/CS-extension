using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShape
{
    public class Circle : AbstractShape
    {
        double pi = 3.1415926535;
        double r;

        public Circle(string name, double r) : base(name)
        {
            this.r = r;
        }
        public override double ShapeArea()
        {
            return pi * (r * r);
        }
    }

}