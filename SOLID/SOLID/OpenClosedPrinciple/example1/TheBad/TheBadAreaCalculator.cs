namespace SOLID.OpenClosedPrinciple.example1.TheBad
{
    public class TheBadAreaCalculator
    {
        public double Area(TheBadRectangle[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }
    }
}
