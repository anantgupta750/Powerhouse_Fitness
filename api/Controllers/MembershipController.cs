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
	public class MembershipsController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public MembershipsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: api/Memberships
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Membership>>> GetMemberships()
		{
			return await _context.Membership.ToListAsync();
		}

		// GET: api/Memberships/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Membership>> GetMembership(int id)
		{
			var membership = await _context.Membership.FindAsync(id);

			if (membership == null)
			{
				return NotFound();
			}

			return membership;
		}

		// POST: api/Memberships
		[HttpPost]
		public async Task<ActionResult<Membership>> CreateMembership(Membership membership)
		{
			_context.Membership.Add(membership);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetMembership), new { id = membership.MembershipId }, membership);
		}

		// PUT: api/Memberships/5
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateMembership(int id, Membership membership)
		{
			if (id != membership.ID)
			{
				return BadRequest();
			}

			_context.Entry(membership).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MembershipExists(id))
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

		// DELETE: api/Memberships/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMembership(int id)
		{
			var membership = await _context.Membership.FindAsync(id);
			if (membership == null)
			{
				return NotFound();
			}

			_context.Membership.Remove(membership);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool MembershipExists(int id)
		{
			return _context.Membership.Any(e => e.ID == id);
		}
	}
}
*/
