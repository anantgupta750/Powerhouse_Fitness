using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Powerhouse_Fitness.Models
{
    public class Membership
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MembershipId { get; set; }

        [ForeignKey("user_registration")]
        public int UserId { get; set; }

        [ForeignKey("Programs")]
        public int ProgramId { get; set; }

        public Programs Programs { get; set; }


        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }

        [Required]
        public Trainer Trainer { get; set; }

        public string Duration { get; set; }

        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Payment details is required")]
        [MaxLength(100)]
        public string Payment { get; set; }
    }
}
