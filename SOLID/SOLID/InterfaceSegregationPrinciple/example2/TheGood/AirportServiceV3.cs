using System;
using System.Collections.Generic;

namespace SOLID.InterfaceSegregationPrinciple.example2.TheGood
{
    // What would be the benefit of this split ?
    // We already established that the consumer does not depend on things he does not use, 
    // so whats the point of splitting this into multiple classes ?
    public class QueryAirportService : IQueryAirportService
    {
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
    }

    public class CommandAirportService : ICommandAirportService
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
