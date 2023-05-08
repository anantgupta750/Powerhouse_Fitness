using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Powerhouse_Fitness.Models
{
    public class membership
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MembershipId { get; set; }

        [ForeignKey("user_registration")]
        public int UserId { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }

        public Program Program { get; set; }


        [ForeignKey("trainer")]
        public int TrainerId { get; set; }

        [Required]
        public trainer trainer { get; set; }

        public string Duration { get; set; }

        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Payment details is required")]
        [MaxLength(100)]
        public string Payment { get; set; }
    }
}
