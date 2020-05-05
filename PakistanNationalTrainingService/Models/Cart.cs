using System.Collections.Generic;
using System.Linq;

namespace PakistanNationalTrainingService.Models
{
	public class Cart
	{
		private List<CartLine> lineCollection = new List<CartLine>();
		public virtual void AddItem(Course course)
		{
			CartLine line = lineCollection
				.Where(lineItem => lineItem.Course.Id == course.Id)
				.FirstOrDefault();

			if (line == null)
			{
				lineCollection.Add(new CartLine
				{
					Course = course
				});

			}
		}
		public virtual void RemoveLine(Course course) => lineCollection.RemoveAll(lineItem => lineItem.Course.Id == course.Id);

		public virtual decimal ComputeTotalValue() => lineCollection.Sum(course => course.Course.Cost);
		public virtual void Clear() => lineCollection.Clear();
		public virtual IEnumerable<CartLine> Lines => lineCollection;
	}
}
