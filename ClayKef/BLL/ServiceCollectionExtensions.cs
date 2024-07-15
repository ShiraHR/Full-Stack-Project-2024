using BLL.BLLApi;
using BLL.BLLImplementation;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection collection,string config)
        { 
            collection.AddRepositories(config);

            collection.AddScoped<IUICourseService, UICourseService>();
            collection.AddScoped<IUIMemberService, UIMemberService>();
            collection.AddScoped<IUIMemberToCourseService, UIMemberToCourseService>();
            collection.AddScoped<IUIAgeService, UIAgeService>();
            collection.AddScoped<IUILevelService, UILevelService>();
            collection.AddScoped<IUIDurationService, UIDuratioService>();
            collection.AddScoped<IUIProductTipeService, UIProductTipeService>();
            collection.AddScoped<IUIPriceService, UIPriceService>();
            collection.AddScoped<IUITimeService, UITImeService>();
            collection.AddScoped<IUICourseService, UICourseService>();
            return collection;
        }
    }



}
