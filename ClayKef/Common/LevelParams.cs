using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LevelParams:BaseQueryParams
    {
        public int code { get; set; }
        public string? type { get; set; }
    }
}
