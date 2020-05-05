using System.ComponentModel.DataAnnotations;

namespace PakistanNationalTrainingService.Models.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		public string Username { get; set; }
		[Required]
		[UIHint("password")]
		public string Password { get; set; }
		public string ReturnUrl { get; set; } = "/";
	}
}
