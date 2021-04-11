using System;

namespace AbstractShape
{
    public abstract class AbstractShape
    {
        public string Name { get; set; }

        public AbstractShape(string name)
        {
            Name = name;
        }

        public abstract double ShapeArea();

    }

}