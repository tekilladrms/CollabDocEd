using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CollabDocEd.Domain;
using CollabDocEd.EF;
using CollabDocEd.Models;
using Microsoft.EntityFrameworkCore;

namespace CollabDocEd.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProfileController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //PROFILES

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            var profile = _context.ClientProfiles.FirstOrDefault(item => item.Email == user.Email);

            if(profile == null)
            {
                profile = CreateProfile(user);
            }

            ProfileViewModel vm = new ProfileViewModel();
            vm.Email = profile.Email;
            vm.Name = profile.Name;
            vm.Projects = await _context.Projects.Where(item => item.CreatorEmail == profile.Email).ToListAsync();
            vm.Projects.AddRange( await _context.Projects.Where(item => item.Users.Any(el => el.Email == profile.Email)).ToListAsync());

            return View(vm);
        }

        private ClientProfile CreateProfile(ApplicationUser user)
        {
            ClientProfile profile = new ClientProfile();
            profile.Id = user.Id;
            profile.Email = user.Email;
            profile.Name = user.UserName;

            _context.ClientProfiles.Add(profile);
            _context.SaveChanges();
            return profile;
        }

    }
}
