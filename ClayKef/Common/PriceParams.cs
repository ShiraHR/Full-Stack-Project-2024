using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PriceParams:BaseQueryParams
    {
        public int code { get; set; }
        public int price { get; set; }
    }
}
