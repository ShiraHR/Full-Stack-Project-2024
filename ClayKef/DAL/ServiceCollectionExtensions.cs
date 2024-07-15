using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection collection, string config)
        {
           collection.AddDbContext<DBContext>(opt => opt.UseSqlServer(config));
            collection.AddDbContext<DBContext>();

            collection.AddScoped<ICourseRepo, CourseRepo>();
            collection.AddScoped<IMembersToCoursesRepo, MemberToCourseRepo>();
            collection.AddScoped<IMemberRepo, MemberRepo>();
            collection.AddScoped<IAgeRepo, AgeRepo>(); // Assuming UIAgeService implements IUIAgeService
            collection.AddScoped<ILevelRepo, LevelRepo>(); // Assuming LevelService implements ILevelService
            collection.AddScoped<IDurationRepo, Durationrepo>(); // Assuming DurationService implements IDurationService
            collection.AddScoped<IIProductTypeRepo, ProductTipeRepo>(); // Assuming ProductTypeService implements IProductTypeService
            collection.AddScoped<IPriceRepo, PriceRepo>(); // Assuming PriceService implements IPriceService
            collection.AddScoped<ITimeRepo, TimeRepo>(); // Assuming TimeService implements ITimeService




        }
    }
}
