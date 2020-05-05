using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Data.Interfaces
{
	public interface ICourseRepository
	{
		IQueryable<Course> Courses { get; }
		void SaveCourse(Course course);
		Course DeleteCourse(int id);
	}
}
