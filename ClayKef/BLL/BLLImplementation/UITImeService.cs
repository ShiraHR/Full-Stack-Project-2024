using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation
{
    public class UITImeService : IUITimeService
    {
        ITimeRepo timeRepo;

        public UITImeService(ITimeRepo timeRepo)
        {
            this.timeRepo = timeRepo;
        }

        public List<UITime> GetAllTimes(BaseQueryParams queryParams)
        {
            var timeParams = queryParams as TimeParams;
            List<Timing> timeTask = new List<Timing>();
            var timeList = new List<UITime>();
            foreach (var time in timeTask)
            {
                UITime newTime = new UITime();
                newTime.Code = time.Code;
                newTime.Day = time.Day;
                newTime.Hour = time.Hour;

                if (time.Date != null)
                {
                    newTime.Date = time.Date;
                }
                timeList.Add(newTime);
            }

            var queryable = timeList.AsQueryable();
            if (timeParams.Hour > 0 && timeParams.Hour < 12)
            {
                queryable = queryable.Where(c => c.Hour == timeParams.Hour);
            }
            if (timeParams.Day > 0 && timeParams.Day < 8)
            {
                queryable = queryable.Where(c => c.Day == timeParams.Day);
            }

            return queryable.ToList();

        }

        public async Task<UITime> PostTime(UITime entity)
        {
            Timing timing = new Timing();
            if (entity.Hour > 0 && entity.Hour < 12 && entity.Day > 0 && entity.Day < 8)
            {
                timing.Hour = entity.Hour;
                timing.Day = entity.Day;
                if (entity.Date != null)
                {
                    timing.Date = entity.Date;
                }

                timeRepo.Post(timing);
            }
            else
            {
                throw new Exception("t5egh");
            }
            return entity;
        }
    }
}
