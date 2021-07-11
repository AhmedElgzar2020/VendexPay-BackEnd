using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Vendexpay.Core;

namespace Vendexpay.Infrastructure
{
    public class HttpUnitOfWork : UnitOfWork
    {
        public HttpUnitOfWork(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context)
        {
            context.CurrentUserId =int.Parse( httpAccessor.HttpContext?.User.FindFirst(ClaimConstants.Subject)?.Value?.Trim());
        }
    }
}
