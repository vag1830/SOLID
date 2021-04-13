using System.Collections.Generic;
using System.Linq;

namespace SOLID.SingleResponsibilityPrinciple.example1
{
    public class TheEvenBetterModule
    {
        private readonly IRepository _repository;

        public TheEvenBetterModule(IRepository repository)
        {
            _repository = repository;
        }

        public IList<string> GetAllItems()
        {
            var items = _repository.GetAllItems();

            return items
                .Select(item => item.Trim())
                .ToList();
        }
    }
}
