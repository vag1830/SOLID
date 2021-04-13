namespace SOLID.OpenClosedPrinciple.example1.TheGood
{
    public class TheGoodAreaCalculatorWhichIsClosedForModificationButCanBeExtended
    {
        public double Area(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
