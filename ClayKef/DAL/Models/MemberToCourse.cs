using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MemberToCourse
{
    public int Code { get; set; }

    public int CourseCode { get; set; }

    public int MemberCode { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
