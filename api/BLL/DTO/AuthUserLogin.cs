using System.ComponentModel.DataAnnotations;

namespace Api.BLL.DTO;

public class AuthUserLogin
{


	[Required]
	[StringLength(100, MinimumLength = 3)]
	public string Email { get; set; } = null!;

	[Required]
	// [StringLength(100)]
	public string Password { get; set; } = null;

}
