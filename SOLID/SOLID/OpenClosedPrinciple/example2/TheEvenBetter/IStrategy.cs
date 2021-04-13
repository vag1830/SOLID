namespace SOLID.OpenClosedPrinciple.example2.TheEvenBetter
{
    public interface IStrategy
    {
        object Do(object data);

        bool CanDo(string what);
    }
}
