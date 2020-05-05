using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Data.Repositories
{
	public class CourseRepository : ICourseRepository
	{
		private ApplicationDbContext context;

		public CourseRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IQueryable<Course> Courses => context.Courses;

		public void SaveCourse(Course course)
		{
			if (course.Id == 0)
			{
				context.Courses.Add(course);
			}
			else
			{
				Course dbEntry = context.Courses.FirstOrDefault(c => c.Id == course.Id);

				if (dbEntry != null)
				{
					dbEntry.Name = course.Name;
					dbEntry.Topic = course.Topic;
					dbEntry.Description = course.Description;
					dbEntry.DeliveryMethod = course.DeliveryMethod;
					dbEntry.Location = course.Location;
					dbEntry.Cost = course.Cost;
				}
			}
			context.SaveChanges();
		}

		public Course DeleteCourse(int id)
		{
			Course dbEntry = context.Courses.FirstOrDefault(course => course.Id == id);

			if (dbEntry != null)
			{
				context.Courses.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
