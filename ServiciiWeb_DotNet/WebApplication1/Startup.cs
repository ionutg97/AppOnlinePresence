using Application.Authentication;
using Application.Services;
using Core.Entities.Authentication;
using Core.Entities.Login;
using Core.Repositories;
using Core.Services;
using Data;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace WebApplication1
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
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ITeachersAccountRepository, TeachersAccountRepository>();

            services.AddScoped<IUsersServices, UsersService>();
            services.AddScoped<ITeachersAccountService, TeacherAccountService>();

            services.AddDbContext<AppDbContext>();


            AppDbContext dbContext = new AppDbContext();
            IAuthentication authentication = new AuthenticationHandler(dbContext);
            services.AddAuthorization(options =>
            {

                options.AddPolicy("Admin", policy =>
                   policy.RequireAssertion(async context =>
                   {
                       String receive = ((AuthorizationFilterContext)(context.Resource)).HttpContext.Request.Headers["Authorization"];

                       if (receive != null)
                       {
                           string[] words = receive.Split(' ');
                           TeacherAccount result = await authentication.FindTeacherAccount(words[0], words[1]);
                           return (result != null);
                       }
                       else
                           return false;
                   }));
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("User", async policy =>
                  policy.RequireAssertion(async context =>
                  {
                      String receive = ((AuthorizationFilterContext)(context.Resource)).HttpContext.Request.Headers["Authorization"];

                      if (receive != null)
                      {
                          string[] words = receive.Split(' ');
                         
                          TeacherAccount result = await authentication.FindTeacherAccount(words[0], words[1]);
                          User resultUser = await authentication.FindUserAccount(words[0], words[1]);
                          if (result != null || resultUser != null)
                              return true;
                          else
                              return false;
                      }
                      else
                          return false;
                  }));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseExceptionHandler("/Error");
            }

            //using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    scope.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
            //}

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
