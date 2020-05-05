using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PakistanNationalTrainingService.Infrastructure;
using System;

namespace PakistanNationalTrainingService.Models
{
	public class SessionCart : Cart
	{
		public static Cart GetCart(IServiceProvider services)
		{
			ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
			SessionCart cart = session?.GetObjectFromJson<SessionCart>("Cart") ?? new SessionCart();
			cart.Session = session;
			return cart;
		}
		[JsonIgnore] public ISession Session { get; set; }
		public override void AddItem(Course course)
		{
			base.AddItem(course);
			Session.SetObjectAsJson("Cart", this);
		}
		public override void RemoveLine(Course course)
		{
			base.RemoveLine(course);
			Session.SetObjectAsJson("Cart", this);
		}
		public override void Clear()
		{
			base.Clear();
			Session.Remove("Cart");
		}
	}
}
