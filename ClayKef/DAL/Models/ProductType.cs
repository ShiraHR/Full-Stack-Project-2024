using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductType
{
    public int Code { get; set; }

    public string Type { get; set; }

    public string Technique { get; set; }

    public int PricingCode { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual Pricing PricingCodeNavigation { get; set; }
}
