using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Data.Interfaces
{
	public interface IOrderRepository
	{
		IQueryable<Order> Orders { get; }
		void SaveOrder(Order order);
	}
}
