using System;
using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example2.TheGood
{
    public interface ICreateAirportService
    {
        Airport Create(Airport airport);
    }

    public interface IUpdateAirportService
    {
        Airport Update(Airport airport);
    }

    public interface IDeleteAirportService
    {
        Airport DeleteById(int id);

        Airport DeleteByIdAndDate(int id, DateTime dateTime);
    }

    public class AirportServiceV4 : IQueryAirportService, IUpdateAirportService, ICreateAirportService, IDeleteAirportService
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
