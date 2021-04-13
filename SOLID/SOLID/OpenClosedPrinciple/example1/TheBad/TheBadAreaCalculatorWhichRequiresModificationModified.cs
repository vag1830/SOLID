using System;

namespace SOLID.OpenClosedPrinciple.example1.TheBad
{
    public class TheBadAreaCalculatorWhichRequiresModificationModified
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is TheBadRectangle)
                {
                    TheBadRectangle rectangle = (TheBadRectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    TheBadCircle circle = (TheBadCircle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
