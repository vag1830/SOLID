using System.Collections.Generic;
using System.Linq;

namespace SOLID.SingleResponsibilityPrinciple.example1
{
    public class TheBadModule
    {
        public IList<string> GetAllItems()
        {
            var repositoryInternalDependency = new Dependency();
            var itemsRepository = new Repository(repositoryInternalDependency);

            var items = itemsRepository.GetAllItems();

            return items
                .Select(item => item.Trim())
                .ToList();
        }
    }
}
