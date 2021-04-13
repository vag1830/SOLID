using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheEvenBetter
{
    class StrategyB : IStrategy
    {
        public bool CanDo(string what)
        {
            if (what == "that")
            {
                return true;
            }

            return false;
        }

        public object Do(object data)
        {
            var list = data as List<string>;

            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
