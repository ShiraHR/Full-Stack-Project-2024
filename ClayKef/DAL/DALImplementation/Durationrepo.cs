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
    public class Durationrepo : IDurationRepo
    {
        DBContext _context;

        public Durationrepo(DBContext context)
        {
            _context = context;
        }
        public Task<Duration> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Duration> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Duration> GetAll(BaseQueryParams queryParams)
        {
            return _context.Durations.ToList();
        }

        public async Task<Duration> Post(Duration entity)
        {
            Duration duration = entity;
            if (duration != null)
                _context.Durations.Add(duration);
            await _context.SaveChangesAsync();
            return duration;
        }

        public Task<Duration> Put(Duration entity)
        {
            throw new NotImplementedException();
        }
    }
}
