using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheEvenBetter
{
    public class TheGoodProgram
    {
        static void Main(string[] args)
        {
            var strategies = new List<IStrategy> { new StrategyA(), new StrategyB() };
            var context = new Context(strategies);

            context.Do(args[1]);
        }
    }
}
