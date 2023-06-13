using System.ComponentModel.DataAnnotations;

namespace Api.BLL.DTO;

public class AddMembershipDTO
{
	public int MembershipId { get; set; }
	public int UserId { get; set; }
	public int ProgramId { get; set; }
	public int TrainerId { get; set; }
	//public string Duration { get; set; }

	public string Payment { get; set; }


}
