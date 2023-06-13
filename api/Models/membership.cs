using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

#nullable disable

public class Membership
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int MembershipId { get; set; }

	[ForeignKey("User")]
	public int UserId { get; set; }

	public User User { get; set; }

	[ForeignKey("TrainingProgram")]
	public int ProgramId { get; set; }

	public TrainingProgram TrainingPrograms { get; set; }

	[ForeignKey("Trainer")]
	public int TrainerId { get; set; }

	public Trainer Trainer { get; set; }
	

	[Required(ErrorMessage = "Payment details is required")]
	[MaxLength(100)]
	public string Payment { get; set; }
}
