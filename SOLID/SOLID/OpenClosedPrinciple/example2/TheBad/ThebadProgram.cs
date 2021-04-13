using System;
using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple.example2.TheBad
{
    public class ThebadProgram
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            if (args[1] == "do this :)")
            {
                Console.WriteLine("Doing this...");

                list.Sort();

                string resultStr = string.Empty;
                foreach (var element in list)
                {
                    resultStr += element + ",";
                }

                Console.WriteLine(resultStr);
            }
            else if (args[1] == "do that :)")
            {
                Console.WriteLine("Doing that...");

                list.Sort();
                list.Reverse();

                string resultStr = string.Empty;
                foreach (var element in list)
                {
                    resultStr += element + ",";
                }

                Console.WriteLine(resultStr);
            }
            else if (true)
            {
                // ... OMG !!!
            }
        }
    }
}
