using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OpenClosedPrinciple.example2.TheEvenBetter
{
    public class Context
    {
        private IList<IStrategy> _strategies;

        public Context(IEnumerable<IStrategy> strategies)
        {
            _strategies = strategies.ToList();
        }

        public void AddStrategy(IStrategy strategy)
        {
            _strategies.Add(strategy);
        }

        public void Do(string what)
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            foreach (var strategy in _strategies)
            {
                if (strategy.CanDo(what))
                {
                    var result = strategy.Do(list);

                    string resultStr = string.Empty;
                    foreach (var element in result as List<string>)
                    {
                        resultStr += element + ",";
                    }

                    Console.WriteLine(resultStr);
                }
            }
        }
    }
}
