﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Controllers
{
	public class OrderController : Controller
	{
		private IOrderRepository repository;
		private Cart cart;

		public OrderController(IOrderRepository repository, Cart cart)
		{
			this.repository = repository;
			this.cart = cart;
		}

		[Authorize]
		public ViewResult List() => View(repository.Orders);

		public ViewResult Checkout()
		{
			return View(new Order());
		}

		[HttpPost]
		public IActionResult Checkout(Order order)
		{
			if (cart.Lines.Count() == 0)
			{
				ModelState.AddModelError("", "Sorry, your cart is empty!");
			}

			if (ModelState.IsValid)
			{
				order.Lines = cart.Lines.ToArray();
				repository.SaveOrder(order);
				return RedirectToAction(nameof(Completed));
			}
			else
			{
				return View(order);
			}
		}

		public ViewResult Completed()
		{
			cart.Clear();
			return View();
		}
	}
}