using System;

namespace SOLID.OpenClosedPrinciple.example1.TheGood
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
