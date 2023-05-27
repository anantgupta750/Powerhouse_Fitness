using Api.DAL.Interface;

using API.Context;
using API.Models;

namespace Api.DAL;

public class TrainerRepository : Repository<Trainer>, ITrainerRepository
{
	private readonly ApplicationDbContext _context;
	public TrainerRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}
}
