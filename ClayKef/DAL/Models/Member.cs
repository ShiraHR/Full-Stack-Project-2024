using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Member
{
    public int Code { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string CellPhone { get; set; }

    public string Email { get; set; }

    public int MemberToCourseCode { get; set; }

    public int TOrF { get; set; }

    public int UserCode { get; set; }

    public virtual MemberToCourse MemberToCourseCodeNavigation { get; set; }
}
