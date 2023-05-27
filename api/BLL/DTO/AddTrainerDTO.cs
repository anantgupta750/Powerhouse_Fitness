using System.ComponentModel.DataAnnotations;

namespace Api.BLL.DTO;

public class AddTrainerDTO
{
	public int TrainerId { get; set; }

	[Required(ErrorMessage = $"{nameof(Name)} is required")]
	[MaxLength(100)]
	public string? Name { get; set; }

	[Required(ErrorMessage = $"{nameof(Gender)} is required")]
	public string? Gender { get; set; }

	[Required(ErrorMessage = "Date of birth is required")]
	[DataType(DataType.Date)]
	public DateTime DateOfBirth { get; set; }

	[Required(ErrorMessage = "Phone number is required")]
	[RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number")]
	public string? Phone { get; set; }

	[Required(ErrorMessage = $"{nameof(Experience)} is required")]
	public int Experience { get; set; }

	[Required(ErrorMessage = $"{nameof(Address)} is required")]
	[MaxLength(100)]
	public string? Address { get; set; }
}
