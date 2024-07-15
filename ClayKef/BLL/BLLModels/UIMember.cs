using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels
{
    public class UIMember
    {
        public int Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int TempOrPerm { get; set; }
        //public List<Course> Courses { get; set; }
        public UIMember(int code, string fname, string lname, string phone, string email,  int tp  /*List<Course> courses*/)
        {
            Code = code;
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            TempOrPerm = tp;
        }
        public UIMember()
        {
            
        }
    }
}
