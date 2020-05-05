using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PakistanNationalTrainingService.Models
{
	public class Order
	{
		[BindNever]
		public int OrderId { get; set; }
		[BindNever]
		public ICollection<CartLine> Lines { get; set; }
		[Display(Name = "First Name"), Required]
		public string FirstName { get; set; }
		[Display(Name = "Last Name"), Required]
		public string LastName { get; set; }
		[Display(Name = "Email Address"), Required]
		public string EmailAddress { get; set; }
		[Display(Name = "Phone Number"), Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Country { get; set; }
		[Display(Name = "First Name")]
		public string BookingContactFirstName { get; set; }
		[Display(Name = "Last Name")]
		public string BookingContactLastName { get; set; }
		[Display(Name = "Email Address")]
		public string BookingContactEmailAddress { get; set; }
		[Display(Name = "Phone Number")]
		public string BookingContactPhoneNumber { get; set; }
		[Required]
		public string Payer { get; set; }
		[Display(Name = "Organization Name")]
		public string PayerOrganizationName { get; set; }
		[Display(Name = "Promotional Code")]
		public string PromotionalCode { get; set; }
		[Display(Name = "Payment Method"), Required]
		public string PaymentMethod { get; set; }
	}
}