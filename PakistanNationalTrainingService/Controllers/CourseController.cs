using Microsoft.AspNetCore.Mvc;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models.ViewModels;
using System.Linq;

namespace PakistanNationalTrainingService.Controllers
{
	public class CourseController : Controller
	{
		private ICourseRepository repository;

		public CourseController(ICourseRepository repository)
		{
			this.repository = repository;
		}

		public ViewResult Index()
		{
			return View(new CoursesListViewModel
			{
				Courses = repository.Courses
			});
		}

		public ViewResult Search(string name, string topic, string deliveryMethod, string location)
		{
			var courses = repository.Courses;

			if (!string.IsNullOrEmpty(name))
			{
				courses = courses.Where(course => course.Name.Contains(name));
			}

			if (!string.IsNullOrEmpty(topic))
			{
				courses = courses.Where(course => course.Topic.Contains(topic));
			}

			if (!string.IsNullOrEmpty(deliveryMethod))
			{
				courses = courses.Where(course => course.DeliveryMethod.Equals(deliveryMethod));
			}

			if (!string.IsNullOrEmpty(location))
			{
				courses = courses.Where(course => course.Location.Equals(location));
			}

			return View(new CoursesListViewModel
			{
				Courses = courses
			});
		}
	}
}