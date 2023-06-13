

using Api.BLL.DTO;
using Api.DAL.Interface;
using API.Models;
using AutoMapper;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	
	public class TrainersController : ControllerBase
	{

		private readonly IMapper _mapper;
		private readonly ITrainerRepository _trainerRepository;

		public TrainersController(ITrainerRepository trainerRepository, IMapper mapper)
		{

			_mapper = mapper;
			_trainerRepository = trainerRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllTrainers()
		{
			var trainer = await _trainerRepository.GetAllAsync();
			var trainerDtos = _mapper.Map<IEnumerable<AddTrainerDTO>>(trainer);
			return Ok(trainerDtos);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetTrainer(int id)
		{
			var trainer = await _trainerRepository.GetByIdAsync(id);
			if (trainer == null)
				return NotFound();
			var trainerDto = _mapper.Map<AddTrainerDTO>(trainer);
			return Ok(trainerDto);
		}
		[HttpPost]
		public async Task<IActionResult> CreateTrainer(AddTrainerDTO trainerDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var trainer = _mapper.Map<Trainer>(trainerDto);

			await _trainerRepository.AddAsync(trainer);
			var createdtrainerDto = _mapper.Map<AddTrainerDTO>(trainer);
			return Ok(createdtrainerDto);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateTrainer(int id, AddTrainerDTO trainerDto)
		{

			var existingTrainer = await _trainerRepository.GetByIdAsync(id);
			if (existingTrainer== null)
				return NotFound();

			_mapper.Map(trainerDto, existingTrainer);

			await _trainerRepository.UpdateAsync(existingTrainer);
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTrainer(int id)
		{
			var existingTrainer = await _trainerRepository.GetByIdAsync(id);
			if (existingTrainer == null)
				return NotFound();

			await _trainerRepository.DeleteAsync(existingTrainer);
			return Ok("User deleted sauccessfully");
		}


	}

}
