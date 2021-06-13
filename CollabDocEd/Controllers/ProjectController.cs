using Amazon.S3;
using Amazon.S3.Model;
using CollabDocEd.AmazonS3;
using CollabDocEd.AuthorizationRequirements;
using CollabDocEd.Domain;
using CollabDocEd.EF;
using CollabDocEd.Models;
using CollabDocEd.Models.ProjectModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ProjectController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy="ShouldBeInvited")]
        [HttpGet]
        public async Task<PartialViewResult> ProjectDetails(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(item => item.Id == id);
            var vm = new ProjectDetailsViewModel();
            if (project != null)
            {
                vm.Id = project.Id;
                vm.Creator = project.CreatorEmail;
                vm.CreateTime = project.CreateTime;
                vm.IsFinished = project.IsFinished;
                
                vm.Users = project.Users;
                vm.Comments = project.Comments;
            }


            return PartialView("_ProjectDetails", vm);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            //get current user
            var user = _userManager.GetUserAsync(User);

            var vm = new CreateProjectViewModel();
            vm.Creator = user.Result.Email;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //Create project
                var project = new Project();
                project.Name = vm.Name;
                project.Description = vm.Description;
                project.CreatorEmail = vm.Creator;
                project.Documents = new List<Document>();
                project.Users = new List<IdentityUser>();

                //Create document
                var document = new Document();
                document.Creator = vm.Creator;
                document.Description = vm.Description;
                document.Filename = vm.File.FileName;

                var s3 = new AmazonS3Service();
                document.FileVersion = await s3.UploadDocumentToBucket(vm.File, vm.Name);

                //get current user
                var user = await _userManager.GetUserAsync(User);

                //add document and user to the project
                project.Documents.Add(document);
                project.Users.Add(user);

                await _context.Projects.AddAsync(project);
                await _context.SaveChangesAsync();

                document.Proj = project.Id;
                _context.Update(document);
                await _context.SaveChangesAsync();
            }
            else
            {
                return View(vm);
            }
            return RedirectToAction("Profile", "Profile");
        }


        [HttpGet]
        public async Task<IActionResult> GetAllUsers(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var vm = new AllUsersModel();
            
            //get project
            var project = await _context.Projects.Include(p => p.Users).FirstOrDefaultAsync(item => item.Id == id);

            if(!project.Users.Contains(user))
            {
                project.Users.Add(user);
                _context.Update(project);
                await _context.SaveChangesAsync();
            }
            vm.ProjectId = project.Id;
            vm.Users = project.Users;
            vm.Creator = project.CreatorEmail;


            return PartialView("_AllUsers", vm);
        }


        [HttpGet]
        public IActionResult InviteUserToProject(int projectId)
        {
            var vm = new InviteUserToProjectModel();
            vm.ProjectId = projectId;
            return PartialView("_InviteUserToProjectModalView", vm);
        }
        [HttpPost]
        public async Task<IActionResult> InviteUserToProject(InviteUserToProjectModel vm)
        {
            if (ModelState.IsValid)
            {
                var invitedUser = await _userManager.FindByEmailAsync(vm.UserEmail);
                //check existing user
                if(invitedUser == null)
                {
                    return NotFound();
                }
                //Get the project
                var project = await _context.Projects.Include(el => el.Users).FirstOrDefaultAsync(item => item.Id == vm.ProjectId);

                project.Users.Add(invitedUser);
                _context.Update(project);
                await _context.SaveChangesAsync();

                return PartialView("_AllUsers", new AllUsersModel()
                {
                    ProjectId = project.Id,
                    Users = project.Users,
                    Creator = project.CreatorEmail
                });
            }
            else 
            {
                return View(vm);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> ExcludeUserFromProject(int projectId, string userId)
        {
            //get current project
            var project = await _context.Projects.Include(p => p.Users).FirstOrDefaultAsync(item => item.Id == projectId);

            if(project != null)
            {
                //get removing user
                var user = await _userManager.FindByIdAsync(userId);

                project.Users.Remove(user);
                _context.Update(project);
                await _context.SaveChangesAsync();

                return PartialView("_AllUsers", new AllUsersModel()
                {
                    ProjectId = projectId,
                    Users = project.Users,
                    Creator = project.CreatorEmail
                });
            }
            else
            {
                return NotFound();
            } 
        }


    }

}
