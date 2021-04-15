namespace SOLID.OpenClosedPrinciple.example2.TheGood
{
    public class TheGoodProgram
    {
        static void Main(string[] args)
        {
            var context = new Context();

            if (args[1] == "do this :)")
            {
                context.SetStrategy(new StrategyA());
                context.Do();
            }
            else if (args[1] == "do that :)")
            {
                context.SetStrategy(new StrategyB());
                context.Do();
            }
            else if (true)
            {
                // ... OMG !!!
            }
        }
    }
}
