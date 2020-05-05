using Microsoft.EntityFrameworkCore;
using PakistanNationalTrainingService.Data.Interfaces;
using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Data.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		private ApplicationDbContext context;
		public OrderRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IQueryable<Order> Orders => context.Orders
			.Include(o => o.Lines)
			.ThenInclude(l => l.Course);
		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(l => l.Course));

			if (order.OrderId == 0)
			{
				context.Orders.Add(order);
			}

			context.SaveChanges();
		}
	}
}
