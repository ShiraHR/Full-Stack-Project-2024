using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface ICourseRepo:ICRUD<Course>
    {
    }
}
