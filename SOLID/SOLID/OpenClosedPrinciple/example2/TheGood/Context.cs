﻿using System;
using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheGood
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Do()
        {
            // Context: Sorting data using the strategy (not sure how it'll do it)
            var result = _strategy.Do(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
