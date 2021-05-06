using System;
using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example2.TheGood
{
    public interface IFmsAirportService
    {
        IList<Airport> GetAll();

        Airport GetById(int id);
    }

    public class FmsAirportService : IFmsAirportService
    {
        public IList<Airport> GetAll()
        {
            throw new NotImplementedException();
        }

        public Airport GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMapsAirportService : ICreateAirportService, IUpdateAirportService, IDeleteAirportService
    {

    }

    public class MapsAirportService : IMapsAirportService
    {
        public Airport Create(Airport airport)
        {
            throw new NotImplementedException();
        }

        public Airport DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Airport DeleteByIdAndDate(int id, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Airport Update(Airport airport)
        {
            throw new NotImplementedException();
        }
    }

}
