using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace PakistanNationalTrainingService.Data
{
	public class IdentityDatabaseSeeder
	{
		private const string adminUser = "Admin";
		private const string adminPassword = "Secret123$";

		public static async void SeedIdentityDatabase(IApplicationBuilder app)
		{
			UserManager<IdentityUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
			IdentityUser user = await userManager.FindByIdAsync(adminUser);

			if (user == null)
			{
				user = new IdentityUser("admin");
				await userManager.CreateAsync(user, adminPassword);
			}
		}
	}
}
