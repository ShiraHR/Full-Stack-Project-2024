using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CoursesParams: BaseQueryParams
    {
        public int CourseCode { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Level { get; set; }
        public int Day { get; set; }
        public double Hour { get; set; }
        public double Price { get; set; }

    
    }
}
