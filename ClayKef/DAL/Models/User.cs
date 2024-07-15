using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class User
{
    public int Code { get; set; }

    public string Password { get; set; }

    public string UserName { get; set; }

    public int AccessRightsCode { get; set; }
}
