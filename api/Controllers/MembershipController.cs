using Api.BLL.DTO;
using Api.DAL.Interface;

using API.Models;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MembershipController : ControllerBase
	{

		private readonly IMapper _mapper;
		private readonly IMembershipRepository _membershipRepository;

		public MembershipController(IMembershipRepository membershipRepository, IMapper mapper)
		{

			_mapper = mapper;
			_membershipRepository = membershipRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllMemberships()
		{
			var membership = await _membershipRepository.GetAllAsync();
			var membershipDtos = _mapper.Map<IEnumerable<AddMembershipDTO>>(membership);
			return Ok(membershipDtos);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetMembership(int id)
		{
			var membership = await _membershipRepository.GetByIdAsync(id);
			if (membership == null)
				return NotFound();
			var membershipDto = _mapper.Map<AddMembershipDTO>(membership);
			return Ok(membershipDto);
		}
		[HttpPost]
		public async Task<IActionResult> CreateMembership(AddMembershipDTO membershipDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var membership = _mapper.Map<Membership>(membershipDto);

			await _membershipRepository.AddAsync(membership);
			var createdmembershipDto = _mapper.Map<AddMembershipDTO>(membership);
			return Ok(createdmembershipDto);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateMembership(int id, AddMembershipDTO membershipDto)
		{

			var existingmembership = await _membershipRepository.GetByIdAsync(id);
			if (existingmembership == null)
				return NotFound();

			_mapper.Map(membershipDto, existingmembership);

			await _membershipRepository.UpdateAsync(existingmembership);
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Deletemembership(int id)
		{
			var existingmembership = await _membershipRepository.GetByIdAsync(id);
			if (existingmembership == null)
				return NotFound();

			await _membershipRepository.DeleteAsync(existingmembership);
			return Ok("User deleted sauccessfully");
		}


	}

}
