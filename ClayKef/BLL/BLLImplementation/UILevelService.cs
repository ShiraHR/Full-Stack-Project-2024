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
    public class UILevelService : IUILevelService
    {
        ILevelRepo levelRepo;

        public UILevelService(ILevelRepo levelRepo)
        {
            this.levelRepo = levelRepo;
        }
        public List<UILevel> GetAllLevels(BaseQueryParams queryParams)
        {
            var levelParams = queryParams as LevelParams;
            List<CourseLevel> levelTask = levelRepo.GetAll(queryParams);
            var LevelList = new List<UILevel>();
            foreach (var level in levelTask)
            {
                UILevel newLevel = new UILevel();
                newLevel.Code = level.Code;
                newLevel.Type = level.Type;
                LevelList.Add(newLevel);
            }
            var queryable = LevelList.AsQueryable();
            if (levelParams.code > 0)
            {
                queryable = queryable.Where(c => c.Code == levelParams.code);
            }
            if (levelParams.type != null)
            {
                queryable = queryable.Where(c => c.Type == levelParams.type);
            }
            return queryable.ToList();
        }
    }
}
