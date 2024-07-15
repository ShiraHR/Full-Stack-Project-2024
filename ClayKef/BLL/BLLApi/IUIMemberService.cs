using BLL.BLLModels;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi
{
    public interface IUIMemberService
    {
        Task<UIMember> GetMemberById(int id);
        Task<UIMember> RemoveMember(int id);
    }
}
