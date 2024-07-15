using Common;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface ICRUD<T>
    {
        List<T> GetAll(BaseQueryParams queryParams);
        Task<T> Get(int id);
        Task<T> Post(T entity);
        Task<T> Delete(int id);
         Task<T> Put(T entity);  
        
    }
}
