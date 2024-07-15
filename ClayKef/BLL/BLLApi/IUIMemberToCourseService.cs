using BLL.BLLModels;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi
{
    public interface IUIMemberToCourseService
    {
        Task<List<UIMember>> GetMembersByCourse(int id);
        Task<UIMemberToCourse> PostMemberToCourese(UIMemberToCourse entity);
        void RemoveMembersCourse(int code);
    }
}
