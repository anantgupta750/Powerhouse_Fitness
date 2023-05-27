/*using API.Models;
using API.Context;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TrainingProgramController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public TrainingProgramController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: api/TrainingPrograms
		[HttpGet]
		public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetTrainingPrograms()
		{
			return await _context.TrainingPrograms.ToListAsync();
		}

		// GET: api/TrainingPrograms/5
		[HttpGet("{id}")]
		public async Task<ActionResult<TrainingProgram>> GetTrainingProgram(int id)
		{
			var trainingProgram = await _context.TrainingPrograms.FindAsync(id);

			if (trainingProgram == null)
			{
				return NotFound();
			}

			return trainingProgram;
		}

		// POST: api/TrainingPrograms
		[HttpPost]
		public async Task<ActionResult<TrainingProgram>> CreateTrainingProgram(TrainingProgram trainingProgram)
		{
			_context.TrainingPrograms.Add(trainingProgram);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetTrainingProgram), new { id = trainingProgram.ProgramId }, trainingProgram);
		}

		// PUT: api/TrainingPrograms/5
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateTrainingProgram(int id, TrainingProgram trainingProgram)
		{
			if (id != trainingProgram.ProgramId)
			{
				return BadRequest();
			}

			_context.Entry(trainingProgram).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!TrainingProgramExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// DELETE: api/TrainingPrograms/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTrainingProgram(int id)
		{
			var trainingProgram = await _context.TrainingPrograms.FindAsync(id);
			if (trainingProgram == null)
			{
				return NotFound();
			}

			_context.TrainingPrograms.Remove(trainingProgram);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TrainingProgramExists(int id)
		{
			return _context.TrainingPrograms.Any(e => e.ProgramId == id);
		}
	}
}
*/
