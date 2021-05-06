using System;

namespace SOLID.InterfaceSegregationPrinciple.example2.TheGood
{
    public class CreateAirportService : ICreateAirportService
    {
        public Airport Create(Airport airport)
        {
            throw new NotImplementedException();
        }
    }

    public class UpdateAirportService : IUpdateAirportService
    {
        public Airport Update(Airport airport)
        {
            throw new NotImplementedException();
        }
    }

    public class DeleteAirportService : IDeleteAirportService
    {
        public Airport DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Airport DeleteByIdAndDate(int id, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
