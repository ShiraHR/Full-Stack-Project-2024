using BLL.BLLApi;
using BLL.BLLImplementation;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLManager
    {
        public UICourseService uicourseRepo { get; }

        public BLLManager()
        {
            ServiceCollection services = new();
            services.AddScoped<DalManger>();
            services.AddScoped<IUICourseService, UICourseService>();
            services.AddScoped<IUIMemberService, UIMemberService>();
            services.AddScoped<IUIMemberToCourseService, UIMemberToCourseService>();
            ServiceProvider servicesProvider = services.BuildServiceProvider();
            uicourseRepo = servicesProvider.GetService<UICourseService>();

        }
    }
}
