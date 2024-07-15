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
    internal class TimeRepo : ITimeRepo
    {
        DBContext _context;

        public TimeRepo(DBContext context)
        {
            _context = context;
        }

        public Task<Timing> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Timing> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Timing> GetAll(BaseQueryParams queryParams)
        {
            return _context.Timings.ToList();
        }

        public async Task<Timing> Post(Timing entity)
        {
            Timing time = entity;
            if (time != null)
                _context.Timings.Add(time);
            await _context.SaveChangesAsync();
            return time;
        }
    

        public Task<Timing> Put(Timing entity)
        {
            throw new NotImplementedException();
        }
    }
}
