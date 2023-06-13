using Api.DAL.Interface;

using API.Context;
using API.Models;

namespace Api.DAL;

public class MembershipRepository : Repository<Membership>, IMembershipRepository
{
	private readonly ApplicationDbContext _context;

	public MembershipRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}

}
