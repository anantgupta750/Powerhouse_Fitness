using Api.DAL.Interface;

using API.Context;
using API.Models;

namespace Api.DAL;

public class TrainingProgramRepository : Repository<TrainingProgram>, ITrainingProgramRepository
{
	private readonly ApplicationDbContext _context;
	public TrainingProgramRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}
}
