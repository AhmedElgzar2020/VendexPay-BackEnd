// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Vendexpay.Core;

namespace Vendexpay.API.Authorization
{
    public class ViewRoleAuthorizationRequirement : IAuthorizationRequirement
    {

    }



    public class ViewRoleAuthorizationHandler : AuthorizationHandler<ViewRoleAuthorizationRequirement, string>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ViewRoleAuthorizationRequirement requirement, string roleName)
        {
            if (context.User == null)
                return Task.CompletedTask;

            if (context.User.HasClaim(ClaimConstants.Permission, ApplicationPermissions.ViewRoles) || context.User.IsInRole(roleName))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
