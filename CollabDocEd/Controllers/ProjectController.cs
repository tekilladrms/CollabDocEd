using Amazon.S3;
using Amazon.S3.Model;
using CollabDocEd.AmazonS3;
using CollabDocEd.AuthorizationRequirements;
using CollabDocEd.Domain;
using CollabDocEd.EF;
using CollabDocEd.Models;
using CollabDocEd.Models.DocumentModels;
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
        private readonly UserManager<ApplicationUser> _userManager;


        public ProjectController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "ShouldBeInvited")]
        [HttpGet]
        public async Task<PartialViewResult> ProjectDetails(int id)
        {
            var project = await _context.Projects
                .Include(p => p.Comments).AsNoTracking()
                .Include(p => p.Documents).AsNoTracking()
                .FirstOrDefaultAsync(item => item.Id == id);
            var vm = new ProjectDetailsViewModel();

            List<IOnScreen> onScreens = new List<IOnScreen>();
            onScreens.AddRange(project.Documents);
            onScreens.AddRange(project.Comments);
            onScreens.GroupBy(item => item.Created);
            return PartialView("_ProjectDetails", new ProjectDetailsViewModel()
            {
                Name = project.Name,
                CreateTime = project.CreateTime,
                Creator = project.CreatorEmail,
                Id = project.Id,
                onScreens = onScreens
            });
        }


        [HttpGet]
        public async Task<IActionResult> AddComment(int projectId)
        {
            var user = await _userManager.GetUserAsync(User);
            var vm = new CommentModel();
            vm.ProjectId = projectId;
            vm.UserEmail = user.Email;
            return PartialView("_AddCommentModalView", vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentModel vm)
        {
            if (String.IsNullOrEmpty(vm.Text))
            {
                return BadRequest();
            }

            //get the project
            var project = await _context.Projects
                .Include(p => p.Comments)
                .Include(p => p.Documents)
                .FirstOrDefaultAsync(item => item.Id == vm.ProjectId);

            //create comment
            Comment comment = new Comment()
            {
                Description = vm.Text,
                Creator = vm.UserEmail
            };

            //add comment to project and save changes
            project.Comments.Add(comment);
            _context.Update(project);
            await _context.SaveChangesAsync();

            List<IOnScreen> onScreens = new List<IOnScreen>();
            onScreens.AddRange(project.Documents);
            onScreens.AddRange(project.Comments);
            onScreens.GroupBy(item => item.Created);
            return PartialView("_ProjectDetails", new ProjectDetailsViewModel()
            {
                Name = project.Name,
                CreateTime = project.CreateTime,
                Creator = project.CreatorEmail,
                Id = project.Id,
                onScreens = onScreens
            });
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
                project.Users = new List<ApplicationUser>();

                //Create document
                var document = new Document();
                document.Creator = vm.Creator;
                document.Description = vm.Description;
                document.Filename = vm.File.FileName;

                // Upload document to Amazon s3
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

            if (!project.Users.Contains(user))
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

        //[Authorize(Policy = "ShouldBeCreator")]
        [HttpGet]
        public IActionResult InviteUserToProject(int projectId)
        {
            var vm = new InviteUserToProjectModel();
            vm.ProjectId = projectId;
            return PartialView("_InviteUserToProjectModalView", vm);
        }

        //[Authorize(Policy = "ShouldBeCreator")]
        [HttpPost]
        public async Task<IActionResult> InviteUserToProject(InviteUserToProjectModel vm)
        {
            if (ModelState.IsValid)
            {
                var invitedUser = await _userManager.FindByEmailAsync(vm.UserEmail);

                //check existing user
                if (invitedUser == null)
                {
                    return NotFound();
                }

                //Get the project
                var project = await _context.Projects.Include(el => el.Users).FirstOrDefaultAsync(item => item.Id == vm.ProjectId);

                if(project != null)
                {
                    if(project.Users.Contains(invitedUser))
                    {
                        
                    }
                    project.Users.Add(invitedUser);
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }

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

        //[Authorize(Policy = "ShouldBeCreator")]
        [HttpPost]
        public async Task<IActionResult> ExcludeUserFromProject(int projectId, string userId)
        {
            //get current project
            var project = await _context.Projects.Include(p => p.Users).FirstOrDefaultAsync(item => item.Id == projectId);

            if (project != null)
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



        [HttpGet]
        public IActionResult DeleteProject(int projectId)
        {
            return PartialView("_DeleteProjectModal", new DeleteProjectModel() { ProjectId = projectId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProject(DeleteProjectModel vm)
        {
            var project = await _context.Projects
                .Include(p => p.Comments)
                .Include(p => p.Documents)
                .FirstOrDefaultAsync(item => item.Id == vm.ProjectId);

            var s3 = new AmazonS3Service();
            var versions = new List<KeyVersion>();

            foreach(var el in project.Documents)
            {
                versions.Add(new KeyVersion() { Key = el.Filename, VersionId = el.FileVersion });
            }

            await s3.DeleteDocumentsFromBucket(versions);
            _context.RemoveRange(project.Documents);
            _context.RemoveRange(project.Comments);
            _context.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }

}
