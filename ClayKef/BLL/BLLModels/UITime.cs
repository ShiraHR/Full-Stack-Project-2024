using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels
{
    public class UITime
    {
        public int Code { get; set; }
        public int Day { get; set; }

        public double Hour { get; set; }

        public DateTime? Date { get; set; }
    }
}
