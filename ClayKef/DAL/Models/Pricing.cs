using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Pricing
{
    public int Code { get; set; }

    public int Price { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();
}
