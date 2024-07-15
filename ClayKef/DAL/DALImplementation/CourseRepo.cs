using Common;
using DAL.DALApi;
using DAL.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DAL.DALImplementation
{
    public class CourseRepo : ICourseRepo
    {
        DBContext _context;

        public CourseRepo(DBContext context)
        {
            _context = context;
        }

        public async Task<Course> Delete(int id)
        {
            if (1 == 1)
            {

                Course course = _context.Courses.FirstOrDefault(c => c.Code == id);
                if (course != null)
                    _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
                return course;
            }
            throw new NotImplementedException();
        }

     /*   public async Task<Course> RemovePatientAsync(string id)
        {
            Course patient = _context.Courses.FirstOrDefault(p => p.Id == id);
            if (patient != null)
                _context.Courses.Remove(patient);
            await _context.SaveChangesAsync();
            return patient;
        }*/

        public async Task<Course> Get(int id)
        {

            return _context.Courses.Include(c => c.AgeCodeNavigation).Include(c => c.CourseLevelCodeNavigation).Include(c => c.PricingCodeNavigation).Include(c => c.TimingCodeNavigation).FirstOrDefault(c => c.Code == id);
        }

        public List<Course> GetAll(BaseQueryParams queryParams)
        {
            return _context.Courses.Include(c => c.AgeCodeNavigation).Include(c => c.CourseLevelCodeNavigation).Include(c => c.PricingCodeNavigation).Include(c => c.TimingCodeNavigation).ToList(); 
            
        }

        public async Task<Course> Post(Course entity)
        {
            if (1 == 1)
            {

                Course course = entity;
                if (course != null)
                    _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return course;
            }
            else { throw new NotImplementedException(); }
        }

        public async Task<Course> Put(Course entity)
        {
       throw new NotImplementedException(); 
           
        }
    }
}
