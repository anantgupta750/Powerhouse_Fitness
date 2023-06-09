﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Api.Models;

namespace API.Models;


#nullable disable

public class User
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int UserId { get; set; }

	[Required(ErrorMessage = "First name is required")]
	public string FirstName { get; set; }

	[Required(ErrorMessage = "Last name is required")]
	public string LastName { get; set; }

	[Required(ErrorMessage = "Email is required")]
	[EmailAddress(ErrorMessage = "Invalid email address")]
	public string Email { get; set; }

	[Required(ErrorMessage = "Password is required")]
	[DataType(DataType.Password)]
	[StringLength(100, MinimumLength = 8)]
	public string Password { get; set; }


	[Required]
	public string Gender { get; set; }

	[Required]
	[DataType(DataType.Date)]
	public DateTime JoinDate { get; set; }

	[Required]
	[DataType(DataType.Date)]
	public DateTime DateOfBirth { get; set; }

	[Required]
	[RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number")]
	public string PhoneNumber { get; set; }

	[Required]
	[MaxLength(100)]
	public string Address { get; set; }

	[ForeignKey("Role")]
	public int roleId { get; set; }

	public Role Roles { get; set; }

}
