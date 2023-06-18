namespace Api.BLL.DTO;

public class AuthResponse
{
	public string token { get; set; }
	public string FirstName { get; set; }
	
	public int RoleId { get; set; }
	public int UserId { get; set; }
}
