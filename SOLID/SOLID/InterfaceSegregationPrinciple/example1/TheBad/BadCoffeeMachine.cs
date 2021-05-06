using System;
using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example1.TheBad
{
    public interface IBadCoffeeMachine
    {
        void AddGroundCoffee(GroundCoffee newCoffee);

        CoffeeDrink BrewFilterCoffee();

        CoffeeDrink BrewEspresso();
    }

    public class BadCoffeeMachine : IBadCoffeeMachine
    {
        private readonly IList<GroundCoffee> Coffee = new List<GroundCoffee>();

        public void AddGroundCoffee(GroundCoffee newCoffee)
        {
            Coffee.Add(newCoffee);
        }

        public CoffeeDrink BrewEspresso()
        {
            return new CoffeeDrink();
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            throw new NotImplementedException("This machine only brews Espresso, Go away!");
        }
    }
}
