using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PakistanNationalTrainingService.Controllers
{
	[Authorize]
	public class AdminController : Controller
	{
		private ICourseRepository repository;


		public AdminController(ICourseRepository repository)
		{
			this.repository = repository;
		}

		public async Task<IActionResult> Index()
		{
			return View(await repository.Courses.ToListAsync());
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var course = await repository.Courses
				.FirstOrDefaultAsync(m => m.Id == id);
			if (course == null)
			{
				return NotFound();
			}

			return View(course);
		}

		public ViewResult Create() => View("Edit", new Course());

		/*public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Topic,Description,DeliveryMethod,Location,TotalSeats,SeatsAvailable,Cost")] Course course)
        {
            if (ModelState.IsValid)
            {
                repository.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }*/

		public ViewResult Edit(int? id)
		{
			var course = repository.Courses.FirstOrDefault(course => course.Id == id);
			return View(course);
		}

		[HttpPost]
		public IActionResult Edit(Course course)
		{
			if (ModelState.IsValid)
			{
				repository.SaveCourse(course);
				return RedirectToAction("Index");
			}
			else
			{
				// there is something wrong with the data values
				return View(course);
			}
		}

		/*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Topic,Description,DeliveryMethod,Location,TotalSeats,SeatsAvailable,Cost")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }*/

		/*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

		[HttpPost]
		public IActionResult Delete(int id)
		{
			_ = repository.DeleteCourse(id);
			return RedirectToAction("Index");
		}

		/*private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }*/
	}
}
