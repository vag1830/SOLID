using System.Collections.Generic;

namespace SOLID.SingleResponsibilityPrinciple.example1
{
    public class Repository
    {
        private readonly Dependency _dependency;

        public Repository(Dependency dependency)
        {
            _dependency = dependency;
        }

        public IList<string> GetAllItems()
        {
            return new List<string>();
        }
    }
}
