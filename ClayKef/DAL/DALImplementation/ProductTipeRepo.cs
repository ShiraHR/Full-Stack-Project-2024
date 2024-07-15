using Common;
using DAL.DALApi;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class ProductTipeRepo : IIProductTypeRepo
    {
        DBContext _context;

        public ProductTipeRepo(DBContext context)
        {
            _context = context;
        }
        public Task<ProductType> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductType> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductType> GetAll(BaseQueryParams queryParams)
        {
            return _context.ProductTypes.ToList();
        }

        public Task<ProductType> Post(ProductType entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductType> Put(ProductType entity)
        {
            throw new NotImplementedException();
        }
    }
}
