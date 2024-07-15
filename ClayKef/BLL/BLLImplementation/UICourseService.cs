using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BLL.BLLImplementation
{
    public class UICourseService : IUICourseService
    {
        ICourseRepo courseRepo;
        IUIMemberToCourseService memberToCourseService;
        IUIAgeService ageService;
        IUILevelService levelService;
        IUIDurationService durationService;
        IUIProductTipeService productTipeService;
        IUIPriceService priceService;
        IUITimeService timeService;
        public UICourseService(ICourseRepo course, IUIMemberToCourseService memberToCourseService, IUIAgeService ageService, IUILevelService levelService, IUIDurationService durationService, IUIProductTipeService prod, IUIPriceService priceService, IUITimeService timeService)
        {
            courseRepo = course;
            this.memberToCourseService = memberToCourseService;
            this.ageService = ageService;
            this.levelService = levelService;
            this.durationService = durationService;
            this.productTipeService = prod;
            this.priceService = priceService;
            this.timeService = timeService;
        }

        public async Task<UICourse> GetCourseById(int id)
        {
            Task<Course> course = courseRepo.Get(id);
            UICourse newCourse = new();
            newCourse.Name = course.Result.Name;
            newCourse.Ageing = course.Result.AgeCodeNavigation.Name;
            newCourse.Level = course.Result.CourseLevelCodeNavigation.Type;
            newCourse.Price = course.Result.PricingCodeNavigation.Price;
            newCourse.Day = course.Result.TimingCodeNavigation.Day;
            newCourse.Hour = (float)course.Result.TimingCodeNavigation.Hour;
            newCourse.NumOfMembers = course.Result.NumOfMembers;
            return newCourse;
        }

        public List<UICourse> GetFilteredCourses(BaseQueryParams queryParams)
        {
            var courseParams = queryParams as CoursesParams;
            List<Course> courseTask = courseRepo.GetAll(queryParams);
            var CourseList = new List<UICourse>();
            foreach (Course course in courseTask)
            {
                UICourse newCourse = new();
                newCourse.Name = course.Name;
                newCourse.Ageing = course.AgeCodeNavigation.Name;
                newCourse.Level = course.CourseLevelCodeNavigation.Type;
                newCourse.Price = course.PricingCodeNavigation.Price;
                newCourse.Day = course.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.NumOfMembers;
                if (1 == 5)
                {
                    newCourse.Members = null;
                }
                else
                {
                    newCourse.Members = memberToCourseService.GetMembersByCourse(course.Code).Result;

                }
                CourseList.Add(newCourse);

            }
            var queryable = CourseList.AsQueryable();
            if (courseParams.Price > 0)
            {
                queryable = queryable.Where(c => c.Price >= courseParams.Price);
            }
            if (courseParams.Name != null)
            {
                queryable = queryable.Where(c => c.Name == courseParams.Name);
            }
            if (courseParams.Age != null)
            {
                queryable = queryable.Where(c => c.Ageing == courseParams.Age);
            }
            if (courseParams.Level != null)
            {
                queryable = queryable.Where(c => c.Level == courseParams.Level);
            }
            if (courseParams.Day > 0)
            {
                queryable = queryable.Where(c => c.Day == courseParams.Day);
            }
            if (courseParams.Hour > 0)
            {
                queryable = queryable.Where(c => c.Hour == courseParams.Hour);
            }
            /* if (1 == 1)
             {

             }
             else { }*/
            return queryable.ToList();
        }

        public async Task<UICourse> PostCourse(UICourse entity)
        {
            Course newCourse = new();
            newCourse.Name = entity.Name;

            AgeParams ageParams = new AgeParams();
            ageParams.name = entity.Ageing;
            newCourse.AgeCode = ageService.GetAllAges(ageParams)[0].Code;

            LevelParams levelParams = new LevelParams();
            levelParams.type = entity.Level;
            newCourse.CourseLevelCode = levelService.GetAllLevels(levelParams)[0].Code;

            DurationParams durationParams = new DurationParams();
            durationParams.Type = entity.duration;
            newCourse.DurationCode = durationService.GetAllDurations(durationParams)[0].Code;


            if (entity.TypeProd != null && entity.TechniqueProd != null)
            {

                ProductParams productParams = new ProductParams();
                productParams.Type = entity.TypeProd;
                productParams.Technique = entity.TechniqueProd;
                newCourse.ProductTypeCode = productTipeService.GetAllProduct(productParams)[0].Code;
            }
            PriceParams priceParams = new PriceParams();
            priceParams.price = entity.Price;
            /*            newCourse.PricingCode = priceService.GetAllPricess(priceParams)[0].Code;*/
            newCourse.PricingCode = 101;

            UITime time = new UITime();
            time.Hour = entity.Hour;
            time.Day = entity.Day;
            if (entity.DateCours != null)
            {
                time.Date = entity.DateCours;
            }
            timeService.PostTime(time);
            TimeParams timeParams = new TimeParams();
            timeParams.Hour = entity.Hour;
            timeParams.Day = entity.Day;
            /*            newCourse.TimingCode = timeService.GetAllTimes(timeParams)[0].Code;*/
            newCourse.Code = 401;

            newCourse.OpeningDate = entity.OpeningDate;
         
/*            newCourse.NumOfMembers = entity.MembersCode.Count;*/
            newCourse.NumOfMembers = entity.NumOfMembers;
            Task<Course> course = courseRepo.Post(newCourse);
/*            foreach (int code in entity.MembersCode)
            {
                UIMemberToCourse uIMemberToCourse = new UIMemberToCourse();
                uIMemberToCourse.MemberCode = code;
                uIMemberToCourse.CourseCode = course.Id;
                //הלוואי שיעבוד... ראית את הרעיון של איך יהיה הקוד של הקורס?
                memberToCourseService.PostMemberToCourese(uIMemberToCourse);
            }*/
            return  entity;
    /*        throw new NotImplementedException();*/
        }

        public Task<UICourse> PutCourse(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UICourse> RemoveCourse(int id)
        {
            Task<Course> course = courseRepo.Delete(id);
            UICourse newCourse = new UICourse();
            newCourse.Code = course.Result.Code;
            newCourse.Name = course.Result.Name;
            newCourse.Ageing = course.Result.AgeCodeNavigation.Name;
            newCourse.Level = course.Result.CourseLevelCodeNavigation.Type;
            newCourse.Price = course.Result.PricingCodeNavigation.Price;
            newCourse.Day = course.Result.TimingCodeNavigation.Day;
            newCourse.Hour = (float)course.Result.TimingCodeNavigation.Hour;
            newCourse.NumOfMembers = course.Result.NumOfMembers;
            /* foreach(MemberToCourse memberTo in course.Result.MemberToCourseCodeNavigation.MemberCode)
             {

             }*/

            return newCourse;
        }

        /*public List<UICourse> GetFilteredCourses(BaseQueryParams queryParams)
        {
            List<Course> courseTask = courseRepo.Get(queryParams);
            var CourseList = new List<UICourse>();
            foreach (Course course in courseTask)
            {
                UICourse newCourse = new();
                newCourse.Name = course.Name;
                newCourse.Ageing = course.AgeCodeNavigation.Name;
                newCourse.Level = course.CourseLevelCodeNavigation.Type;
                newCourse.Price = cour se.PricingCodeNavigation.Price;
                newCourse.Day = course.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.NumOfMembers;
                CourseList.Add(newCourse);
            }
            return CourseList;
        }*/
    }
}

