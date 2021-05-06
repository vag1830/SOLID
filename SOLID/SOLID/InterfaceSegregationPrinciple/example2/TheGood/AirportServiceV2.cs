using System;
using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example2.TheGood
{
    public interface IQueryAirportService
    {
        IList<Airport> GetAll();

        Airport GetById(int id);

        Airport GetByIdAndDate(int id, DateTime dateTime);

        IList<Airport> Search(string term);
    }

    public interface ICommandAirportService
    {
        Airport Create(Airport airport);

        Airport Update(Airport airport);

        Airport DeleteById(int id);

        Airport DeleteByIdAndDate(int id, DateTime dateTime);
    }

    // It seems like the code still lives all together in one class
    // What would be the benefit of this ?
    public class AirportServiceV200 : IQueryAirportService, ICommandAirportService
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

        public IList<Airport> GetAll()
        {
            throw new NotImplementedException();
        }

        public Airport GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Airport GetByIdAndDate(int id, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IList<Airport> Search(string term)
        {
            throw new NotImplementedException();
        }

        public Airport Update(Airport airport)
        {
            throw new NotImplementedException();
        }
    }
}
