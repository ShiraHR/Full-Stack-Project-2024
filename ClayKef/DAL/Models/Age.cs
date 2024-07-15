using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Age
{
    public int Code { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
