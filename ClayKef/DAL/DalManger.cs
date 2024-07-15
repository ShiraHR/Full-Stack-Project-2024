using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalManger
    {
        public CourseRepo Courses { get; }
        public DalManger() {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ICourseRepo, CourseRepo>();
            ServiceProvider servicesProvider = services.BuildServiceProvider();
        }
    }
}
