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
    public class AgeRepo : IAgeRepo
    {

        DBContext _context;

        public AgeRepo(DBContext context)
        {
            _context = context;
        }
        public Task<Age> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Age> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Age> GetAll(BaseQueryParams queryParams)
        {
            return _context.Ages.ToList();
        }

        public Task<Age> Post(Age entity)
        {
            throw new NotImplementedException();
        }

        public Task<Age> Put(Age entity)
        {
            throw new NotImplementedException();
        }
    }
}
