using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheGood
{
    class StrategyA : IStrategy
    {
        public object Do(object data)
        {
            var list = data as List<string>;

            list.Sort();

            return list;
        }
    }
}
