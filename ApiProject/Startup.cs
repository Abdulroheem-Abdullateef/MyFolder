// using ApiProject.Implementations.Repositories;
// using ApiProject.Interfaces.IRepositories;
// using ApiProject.Interfaces.IServices;
// using ApiProject.Implementations.Services;
using ApiProject.Implementations.Repositories;
using ApiProject.Implementations.Services;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;
using ApiProject.SendingMessages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using ApiProject.Implementations.Services;

namespace ApiProject
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
            services.AddDbContext<MyContext>(options =>
                   options.UseMySQL(Configuration.GetConnectionString("ConnectionContext")));
            services.AddControllersWithViews();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IHospitalRepository, HospitalRepository>();
            services.AddScoped<IHospitalService, HospitalService>();
            services.AddScoped<IMedicalRecordRepository, MedicalRecordRepository>();
            services.AddScoped<IMedicalRecordService, MedicalRecordService>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMailMessage, MailMessage>();
            services.AddScoped<IDoctorMedicalRecordRepository, DoctorMedicalRecordRepository>();
            services.AddAuthentication();
            services.AddAuthorization();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(config =>
            {
                config.LoginPath = "/User/LogIn";
                config.Cookie.Name = "DoctorApp";
                config.LogoutPath = "/User/LogOut";
            });
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Patient}/{action=Index}/{id?}");
            });
        }
    }
}
