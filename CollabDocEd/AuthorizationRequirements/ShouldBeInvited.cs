﻿using CollabDocEd.EF;
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
        public ShouldBeInvitedHandler(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ShouldBeInvited requirement)
        {

            //check for existing clime
            if (!context.User.HasClaim(x => x.Type == ClaimTypes.Email))
                return Task.CompletedTask;

            //get Email-claim
            var emailAddress = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;

            //get endpoint
            var endpoint = _httpContextAccessor.HttpContext.Request.Path.Value;

            //get projectId from endpoint
            var projectId = Int32.Parse(endpoint.Substring(endpoint.LastIndexOf("/")).Trim(new char[] { '/' }));


            var project = _context.Projects.Include(p => p.Users).FirstOrDefault(item => item.Id == projectId);

            if((project != null
                && project.Users.Any(item => item.Email == emailAddress))
                || project.CreatorEmail == emailAddress
                )
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;

        }
    }
}
