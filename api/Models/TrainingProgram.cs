using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

#nullable disable

public class TrainingProgram
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ProgramId { get; set; }

	[Required(ErrorMessage = $"{nameof(Name)} is required")]
	[MaxLength(100)]
	public string Name { get; set; }

	[Required(ErrorMessage = $"{nameof(Duration)} is required")]
	//[DataType(DataType.Date)]

	public int Duration { get; set; }

	[Required(ErrorMessage = $"{nameof(Description)} is required")]
	[MaxLength(1000)]
	public string Description { get; set; }

	[Required(ErrorMessage = $"{nameof(Cost)} is required")]
	[DataType(DataType.Currency)]
	public decimal Cost { get; set; }

	[ForeignKey("Trainer")]
	public int TrainerId { get; set; }
	public Trainer Trainers { get; set; }


}
