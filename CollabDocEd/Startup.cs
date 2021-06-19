
using Amazon.S3;
using CollabDocEd.AuthorizationRequirements;
using CollabDocEd.Domain;
using CollabDocEd.EF;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CollabDocEd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            //add accessor for get endpoints in AuthorizationHandlers
            services.AddHttpContextAccessor();

            var awsOptions = Configuration.GetAWSOptions();
            services.AddDefaultAWSOptions(awsOptions);

            //add Identity
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredUniqueChars = 0;

            })

                .AddEntityFrameworkStores<ApplicationDbContext>();

            //Add OAuth authentication
            services.AddAuthentication()
                .AddCookie()
                .AddGoogle(options =>
                {
                    
                    options.ClientId = Configuration["App:GoogleClientId"];
                    options.ClientSecret = Configuration["App:GoogleClientSecret"];
                    
                })
                
                .AddVkontakte(options =>
                {
                    options.ClientId = Configuration["App:VkClientId"];
                    options.ClientSecret = Configuration["App:VkClientSecret"];
                });

            //register AuthorizationHandlers
            services.AddTransient<IAuthorizationHandler, ShouldBeInvitedHandler>();
            //services.AddTransient<IAuthorizationHandler, ShouldBeCreatorHandler>();

            //add policies
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ShouldBeInvited", policy => policy.Requirements.Add(new ShouldBeInvited()));
                //options.AddPolicy("ShouldBeCreator", policy => policy.Requirements.Add(new ShouldBeCreator()));
            });

            services.AddRazorPages();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
