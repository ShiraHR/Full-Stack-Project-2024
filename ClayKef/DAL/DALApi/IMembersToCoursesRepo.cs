using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface IMembersToCoursesRepo:ICRUD<MemberToCourse>
    {
        List<MemberToCourse> GetByCourse(int id);
        List<MemberToCourse> GetByMember(int id);
        List<MemberToCourse> DeleteByCourse(int code);
    }
}
