using API.Models;

namespace Api.DAL.Interface;

public interface IUserRepository : IRepository<User>
{
	Task<User> GetByEmailAsync(string email);
}
