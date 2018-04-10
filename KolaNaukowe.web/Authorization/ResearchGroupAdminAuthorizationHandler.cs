using KolaNaukowe.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Authorization
{
    public class ResearchGroupAdminAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, StudentResearchGroup>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, StudentResearchGroup resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            if (context.User.IsInRole(Constants.AdministratorRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}