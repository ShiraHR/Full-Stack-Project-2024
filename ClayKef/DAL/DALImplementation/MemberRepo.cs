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
    public class MemberRepo : IMemberRepo
    {
        DBContext _context;
        public MemberRepo(DBContext context)
        {
            _context = context;
        }
        public Task<Member> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Member> Get(int id)
        {
            return _context.Members.FirstOrDefault(m => m.Code == id);
        }

        public List<Member> GetAll(BaseQueryParams queryParams)
        {
            return _context.Members.ToList();
        }

        public Task<Member> Post(Member entity)
        {
            throw new NotImplementedException();
        }

        public Task<Member> Put(Member entity)
        {
            throw new NotImplementedException();
        }
    }
}
