using Api.DAL.Interface;

using API.Context;
using API.Models;

using Microsoft.EntityFrameworkCore;

namespace Api.DAL;

public class UserRepository : Repository<User>, IUserRepository
{
	private readonly ApplicationDbContext _context;
	public UserRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}
	public async Task<User> GetByEmailAsync(string email)
	{
		return await _context.UserRegistrations.Include("Roles").FirstOrDefaultAsync(x => x.Email == email);
	}
}
