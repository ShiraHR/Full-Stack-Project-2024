using BLL.BLLApi;
using BLL.BLLModels;
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
    public class UIMemberService : IUIMemberService
    {
        IMemberRepo memberRepo;
        public UIMemberService(IMemberRepo memberRepo)
        {
            this.memberRepo = memberRepo;
        }
        public async Task<UIMember> GetMemberById(int id)
        {
            Task<Member> member = memberRepo.Get(id);
            UIMember newMember = new UIMember();
            newMember.FirstName = member.Result.FirstName;
            newMember.LastName = member.Result.LastName;
            newMember.TempOrPerm = member.Result.TOrF;
            newMember.Email = member.Result.Email;
            newMember.Phone = member.Result.CellPhone;
            newMember.Code = member.Result.Code;
           
            return newMember;
        }

        public Task<UIMember> RemoveMember(int id)
        {
            throw new NotImplementedException();
        }
    }
}
