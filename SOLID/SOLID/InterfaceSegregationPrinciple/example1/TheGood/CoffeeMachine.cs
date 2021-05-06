using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example1.TheGood
{
    public interface ICoffeeMachine
    {
        void AddGroundCoffee(GroundCoffee newCoffee);
    }

    public interface IFilterCoffeeMachine : ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
    }

    public interface IEspressCoffeeMachine : ICoffeeMachine
    {
        CoffeeDrink BrewEspressoCoffee();
    }

    public class FilterCoffeeMachine : IFilterCoffeeMachine
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

    public class EspressCoffeeMachine : IEspressCoffeeMachine
    {
        private readonly IList<GroundCoffee> Coffee = new List<GroundCoffee>();

        public void AddGroundCoffee(GroundCoffee newCoffee)
        {
            Coffee.Add(newCoffee);
        }

        public CoffeeDrink BrewEspressoCoffee()
        {
            return new CoffeeDrink();
        }
    }
}

/*                  ICoffeeMachine
                        /   \
                       /     \
                      /       \
    IFilterCoffeeMachine      IEspressCoffeeMachine
             |                         |
             |                         |
             |                         |
    FilterCoffeeMachine       EspressCoffeeMachine

*/
