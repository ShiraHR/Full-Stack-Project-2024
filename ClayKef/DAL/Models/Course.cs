using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Course
{
    public int Code { get; set; }

    public string Name { get; set; }

    public DateTime OpeningDate { get; set; }

    public int NumOfMembers { get; set; }

    public int DurationCode { get; set; }

    public int TimingCode { get; set; }

    public int AgeCode { get; set; }

    public int PricingCode { get; set; }

    public int? ProductTypeCode { get; set; }

    public int CourseLevelCode { get; set; }

    public int MemberToCourseCode { get; set; }

    public virtual Age AgeCodeNavigation { get; set; }

    public virtual CourseLevel CourseLevelCodeNavigation { get; set; }

    public virtual Duration DurationCodeNavigation { get; set; }

    public virtual MemberToCourse MemberToCourseCodeNavigation { get; set; }

    public virtual Pricing PricingCodeNavigation { get; set; }

    public virtual ProductType ProductTypeCodeNavigation { get; set; }

    public virtual Timing TimingCodeNavigation { get; set; }
}
