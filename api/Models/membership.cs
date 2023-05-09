using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

#nullable disable

public class Membership
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ID { get; set; }

	[ForeignKey(nameof(User))]
	public int UserId { get; set; }

	public User User { get; set; }

	[ForeignKey(nameof(TrainingProgram))]
	public int TrainerProgramID { get; set; }

	public TrainingProgram TrainingProgram { get; set; }

	[ForeignKey("Trainer")]
	public int TrainerId { get; set; }

	[Required]
	public Trainer Trainer { get; set; }
	[Required]
	public string Duration { get; set; }
	[Required]
	[DataType(DataType.Currency)]
	public decimal Cost { get; set; }

	[Required(ErrorMessage = "Payment details is required")]
	[MaxLength(100)]
	public string Payment { get; set; }
}
