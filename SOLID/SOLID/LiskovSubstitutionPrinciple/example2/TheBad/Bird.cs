using System;

namespace SOLID.LiskovSubstitutionPrinciple.example2.TheBad
{
    public interface IBird
    {
        void MakeSound();

        void LayEgg();

        void Fly();
    }

    public class Duck : IBird
    {
        public void Fly()
        {
            // implements Fly... 
        }

        public void LayEgg()
        {
            // implements LayEgg ...
        }

        public void MakeSound()
        {
            /// implements MakeSound ...
        }
    }

    public class Pigeon : IBird
    {
        public void Fly()
        {
            // implements Fly... 
        }

        public void LayEgg()
        {
            // implements LayEgg ...
        }

        public void MakeSound()
        {
            /// implements MakeSound ...
        }
    }

    public class Chicken : IBird
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void LayEgg()
        {
            // implements LayEgg ...
        }

        public void MakeSound()
        {
            /// implements MakeSound ...
        }
    }

    public class Program
    {
        public void main()
        {
            IBird bird = new Pigeon();
            bird.Fly();

            // throws
            bird = new Chicken();
            bird.Fly();
        }
    }
}
