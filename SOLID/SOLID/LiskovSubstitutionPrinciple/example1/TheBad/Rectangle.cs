using System;

namespace SOLID.LiskovSubstitutionPrinciple.example1.TheBad
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public int Area => Height * Width;
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            get { return Width; }
            set
            {
                Width = value;
                Height = value;
            }
        }

        public override int Height
        {
            get { return Height; }
            set
            {
                Height = value;
                Width = value;
            }
        }
    }

    public class Program
    {
        void main()
        {
            var rectangleFactory = new RectangleFactory();
            Rectangle rectangle = rectangleFactory.CreateRectangle();

            rectangle.Width = 5;
            rectangle.Height = 2;

            // Square violates Liskov's Substitution principle and the result is unexpected.
            Console.WriteLine(rectangle.Area); // 4
        }
    }

    public class RectangleFactory
    {
        public Rectangle CreateRectangle()
        {
            return new Square();
        }
    }
}
