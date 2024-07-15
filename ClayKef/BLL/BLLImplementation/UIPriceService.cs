using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation
{
    public class UIPriceService : IUIPriceService
    {
        IPriceRepo priceRepo;

        public UIPriceService(IPriceRepo priceRepo)
        {
            this.priceRepo = priceRepo;
        }
        public List<UIPrice> GetAllPricess(BaseQueryParams queryParams)
        {
            var priceParams = queryParams as PriceParams;
            List<Pricing> pricingTask = priceRepo.GetAll(queryParams);
            var priceList =new List<UIPrice>();
            foreach  (Pricing pricing in pricingTask)
            {
                UIPrice price = new UIPrice();
                price.Price = pricing.Price;
                price.Code = pricing.Code;
                priceList.Add(price);
            }
            var queryable = priceList.AsQueryable();
            if (priceParams.price > 0)
            {
                queryable = queryable.Where(c => c.Price == priceParams.price);
            }

            return queryable.ToList();
        }
    }
}
