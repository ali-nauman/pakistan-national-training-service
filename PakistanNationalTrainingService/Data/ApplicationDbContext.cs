using Microsoft.EntityFrameworkCore;
using PakistanNationalTrainingService.Models;

namespace PakistanNationalTrainingService.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
