using KolaNaukowe.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Authorization
{
    public class ResearchGroupLeaderAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, StudentResearchGroup>
    {
        UserManager<ApplicationUser> _userManager;

        public ResearchGroupLeaderAuthorizationHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager; 
        } 

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, StudentResearchGroup resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            if (
                requirement.Name != Constants.ReadOperationName   &&
                requirement.Name != Constants.UpdateOperationName 
                )
            {
                return Task.CompletedTask;
            }

            if(resource.OwnerId == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
