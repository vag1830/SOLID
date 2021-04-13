using System.Collections.Generic;

namespace SOLID.SingleResponsibilityPrinciple.example1
{
    public interface IRepository
    {
        IList<string> GetAllItems();
    }
}
