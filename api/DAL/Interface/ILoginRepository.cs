using API.Models;

namespace Api.DAL.Interface;

public interface ILoginRepository
{
	Task<User> GetByEmailAsync(string email);
}
