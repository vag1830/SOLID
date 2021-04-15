using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SOLID.LiskovSubstitutionPrinciple.example3.TheBad
{
    public class Item { }

    public interface IItemRepository
    {
        ICollection<Item> GetAllItems();
    }

    public class ItemRepository : IItemRepository
    {
        public ICollection<Item> GetAllItems()
        {
            // violates the Interface
            return new ReadOnlyCollection<Item>(new List<Item> {
                new Item(),
                new Item()
            });
        }
    }

    public class Program
    {
        public void main()
        {
            IItemRepository repo = new ItemRepository();

            var items = repo.GetAllItems();

            // Throws
            items.Add(new Item());
        }
    }
}
