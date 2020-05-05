using System.ComponentModel.DataAnnotations;

namespace PakistanNationalTrainingService.Models
{
	public class Course
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Topic { get; set; }

		public string Description { get; set; }

		[Display(Name = "Delivery Method")]
		public string DeliveryMethod { get; set; }

		public string Location { get; set; }

		[Display(Name = "Total Seats")]
		public int TotalSeats { get; set; }

		[Display(Name = "Seats Available")]
		public int SeatsAvailable { get; set; }

		public int Cost { get; set; }
	}
}