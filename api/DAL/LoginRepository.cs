using API.Context;
using Api.DAL.Interface;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DAL;

public class LoginRepository : ILoginRepository
{
	private readonly ApplicationDbContext _context;
	public LoginRepository(ApplicationDbContext context)
	{
		_context = context;
	}
	public async Task<User> GetByEmailAsync(string email)
	{
		return await _context.UserRegistrations.Include("Roles").FirstOrDefaultAsync(x => x.Email == email);
	}
}
