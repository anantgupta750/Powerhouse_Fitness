using Api.DAL.Interface;

using API.Context;
using API.Models;

namespace Api.DAL;

public class UserRepository : Repository<User>, IUserRepository
{
	private readonly ApplicationDbContext _context;
	public UserRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}
}
