namespace SOLID.OpenClosedPrinciple.example1.TheGood
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}
