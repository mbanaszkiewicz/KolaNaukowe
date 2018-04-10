using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Authorization
{
    public class RoleRequirement : IAuthorizationRequirement
    {
       public List<string> Roles { get; set; }

        public RoleRequirement(List<string> roles)
        {
            Roles = roles;
        }
    }
}
