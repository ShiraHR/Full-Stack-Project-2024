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
    public class UIAgeService : IUIAgeService
    {
        IAgeRepo ageRepo;
       
        public UIAgeService(IAgeRepo ageRepo)
        {
            this.ageRepo = ageRepo;
        }
        public List<UIAge> GetAllAges(BaseQueryParams queryParams)
        {
            var ageParams = queryParams as AgeParams;
            List<Age> ageTask = ageRepo.GetAll(queryParams);
            var AgeList = new List<UIAge>();
            foreach (var age in ageTask)
            {
                UIAge newAge = new UIAge();
                newAge.Code=age.Code;
                newAge.Name =age.Name;
                AgeList.Add(newAge);
            }
            var queryable =AgeList.AsQueryable();
            if (ageParams.code > 0)
            {
                queryable = queryable.Where(c => c.Code == ageParams.code);
            }
            if (ageParams.name != null)
            {
                queryable = queryable.Where(c => c.Name == ageParams.name);
            }
            return queryable.ToList();
        }
    }
}
