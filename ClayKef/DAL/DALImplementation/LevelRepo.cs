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
    public class LevelRepo : ILevelRepo
    {
        DBContext _context;

        public LevelRepo(DBContext context)
        {
            _context = context;
        }
        public Task<CourseLevel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseLevel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseLevel> GetAll(BaseQueryParams queryParams)
        {
            return _context.CourseLevels.ToList();
        }

        public Task<CourseLevel> Post(CourseLevel entity)
        {
            throw new NotImplementedException();
        }

        public Task<CourseLevel> Put(CourseLevel entity)
        {
            throw new NotImplementedException();
        }
    }
}
