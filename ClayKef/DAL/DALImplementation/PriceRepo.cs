using Common;
using DAL.DALApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class PriceRepo : IPriceRepo
    {
        DBContext _context;

        public PriceRepo(DBContext context)
        {
            _context = context;
        }
        public Task<Pricing> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pricing> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pricing> GetAll(BaseQueryParams queryParams)
        {
            return _context.Pricings.ToList();
        }

        public Task<Pricing> Post(Pricing entity)
        {
            throw new NotImplementedException();
        }

        public Task<Pricing> Put(Pricing entity)
        {
            throw new NotImplementedException();
        }
    }
}
