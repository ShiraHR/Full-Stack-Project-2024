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
    public class UIProductTipeService : IUIProductTipeService
    {

        IIProductTypeRepo productTypeRepo;
        IUIPriceService priceService;

        public UIProductTipeService(IIProductTypeRepo productTypeRepo, IUIPriceService priceService)
        {
            this.productTypeRepo = productTypeRepo;
            this.priceService = priceService;
        }

        public List<UIProductTipe> GetAllProduct(BaseQueryParams queryParams)
        {
            var productParams = queryParams as ProductParams;
            List<ProductType> productTask = productTypeRepo.GetAll(queryParams);
            var productList = new List<UIProductTipe>();
            foreach (var prod in productTask)
            {
                UIProductTipe newproduct = new UIProductTipe();
                newproduct.Code = prod.Code;
                newproduct.Type =prod.Type;
                newproduct.Technique = prod.Technique;
                newproduct.Price = prod.PricingCodeNavigation.Price;
                productList.Add(newproduct);
            }
            var queryable = productList.AsQueryable();
            if (productParams.Type != null)
            {
                queryable = queryable.Where(c => c.Type == productParams.Type);
            }
            if (productParams.Technique != null)
            {
                queryable = queryable.Where(c => c.Technique == productParams.Technique);
            }
            return queryable.ToList();
        }
    }
}
