using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example1.TheBad
{
    public interface ICoffeeMachine
    {
        void AddGroundCoffee(GroundCoffee newCoffee);

        CoffeeDrink BrewFilterCoffee();
    }

    public class CoffeeMachine : ICoffeeMachine
    {
        private readonly IList<GroundCoffee> Coffee = new List<GroundCoffee>();

        public void AddGroundCoffee(GroundCoffee newCoffee)
        {
            Coffee.Add(newCoffee);
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            return new CoffeeDrink();
        }
    }
}
