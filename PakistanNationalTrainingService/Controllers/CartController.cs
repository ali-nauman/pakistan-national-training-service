using Microsoft.AspNetCore.Mvc;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models;
using PakistanNationalTrainingService.Models.ViewModels;
using System.Linq;

namespace PakistanNationalTrainingService.Controllers
{
	public class CartController : Controller
	{
		private ICourseRepository repository;
		private Cart cart;

		public CartController(ICourseRepository repository, Cart cart)
		{
			this.repository = repository;
			this.cart = cart;
		}

		public ViewResult Index(string returnUrl)
		{
			return View(new CartIndexViewModel
			{
				Cart = cart,
				ReturnUrl = returnUrl
			});
		}

		public RedirectToActionResult AddToCart(int id, string returnUrl)
		{
			Course courseToAdd = repository.Courses.FirstOrDefault(course => course.Id == id);

			if (courseToAdd != null)
			{
				cart.AddItem(courseToAdd);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		public RedirectToActionResult RemoveFromCart(int id, string returnUrl)
		{
			Course courseToRemove = repository.Courses.FirstOrDefault(course => course.Id == id);

			if (courseToRemove != null)
			{
				cart.RemoveLine(courseToRemove);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		/*private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart") ?? new Cart();
            return cart;
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetObjectAsJson("Cart", cart);
        }*/
	}
}