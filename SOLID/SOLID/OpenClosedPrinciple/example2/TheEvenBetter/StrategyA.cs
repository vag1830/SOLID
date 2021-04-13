using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheEvenBetter
{
    class StrategyA : IStrategy
    {
        public bool CanDo(string what)
        {
            if (what == "this")
            {
                return true;
            }

            return false;
        }

        public object Do(object data)
        {
            var list = data as List<string>;

            list.Sort();

            return list;
        }
    }
}
