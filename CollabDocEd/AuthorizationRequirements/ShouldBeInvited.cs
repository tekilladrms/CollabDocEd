using CollabDocEd.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CollabDocEd.AuthorizationRequirements
{
    public class ShouldBeInvited : IAuthorizationRequirement
    {
        public ShouldBeInvited()
        {
            
        }
    }

    public class ShouldBeInvitedHandler : AuthorizationHandler<ShouldBeInvited>
    {
        private ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ShouldBeInvitedHandler(ApplicationDbContext context)
        {

            _context = context;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ShouldBeInvited requirement)
        {

            //check for existing clime
            if (!context.User.HasClaim(x => x.Type == ClaimTypes.Email))
                return Task.CompletedTask;


            var emailAddress = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;

            var endpoint = _httpContextAccessor.HttpContext.GetEndpoint();
            var projectId = Int32.Parse(endpoint.DisplayName);


            var project = _context.Projects.Include(p => p.Users).FirstOrDefault(item => item.Id == projectId);

            if(project != null && project.Users.Any(item => item.Email == emailAddress))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;

        }
    }
}
