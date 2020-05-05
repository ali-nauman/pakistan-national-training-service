using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PakistanNationalTrainingService.Data;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Data.Repositories;
using PakistanNationalTrainingService.Models;

namespace PakistanNationalTrainingService
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();

			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PNTSCourses")));

			services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PNTSIdentity")));

			services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationIdentityDbContext>().AddDefaultTokenProviders();

			services.AddTransient<ICourseRepository, CourseRepository>();
			services.AddScoped(sp => SessionCart.GetCart(sp));
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddTransient<IOrderRepository, OrderRepository>();
			services.AddMemoryCache();
			services.AddSession();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();
			app.UseSession();
			app.UseAuthentication();
			app.UseRouting();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});

			DatabaseSeeder.SeedDatabase(app);
			IdentityDatabaseSeeder.SeedIdentityDatabase(app);
		}
	}
}
