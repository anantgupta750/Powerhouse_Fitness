

using Api.BLL.DTO;
using Api.DAL.Interface;
using API.Models;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TrainingProgramController : ControllerBase
	{

		private readonly IMapper _mapper;
		private readonly ITrainingProgramRepository _trainingProgramRepository;

		public TrainingProgramController(ITrainingProgramRepository trainingProgramRepository, IMapper mapper)
		{

			_mapper = mapper;
			_trainingProgramRepository = trainingProgramRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllTrainingProgram()
		{
			var trainingProgram = await _trainingProgramRepository.GetAllAsync();
			var trainingProgramDtos = _mapper.Map<IEnumerable<AddTrainingProgramDTO>>(trainingProgram);
			return Ok(trainingProgramDtos);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetTrainingProgram(int id)
		{
			var trainingProgram = await _trainingProgramRepository.GetByIdAsync(id);
			if (trainingProgram == null)
				return NotFound();
			var trainingProgramDto = _mapper.Map<AddTrainingProgramDTO>(trainingProgram);
			return Ok(trainingProgramDto);
		}
		[HttpPost]
		public async Task<IActionResult> CreateTrainingProgram(AddTrainingProgramDTO trainingProgramDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var trainingProgram = _mapper.Map<TrainingProgram>(trainingProgramDto);

			await _trainingProgramRepository.AddAsync(trainingProgram);
			var createdtrainingProgramDto = _mapper.Map<AddTrainingProgramDTO>(trainingProgram);
			return Ok(createdtrainingProgramDto);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateTrainer(int id, AddTrainingProgramDTO trainingProgramDto)
		{

			var existingTrainingProgram = await _trainingProgramRepository.GetByIdAsync(id);
			if (existingTrainingProgram== null)
				return NotFound();

			_mapper.Map(trainingProgramDto, existingTrainingProgram);

			await _trainingProgramRepository.UpdateAsync(existingTrainingProgram);
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTrainingProgram(int id)
		{
			var existingTrainingProgram = await _trainingProgramRepository.GetByIdAsync(id);
			if (existingTrainingProgram == null)
				return NotFound();

			await _trainingProgramRepository.DeleteAsync(existingTrainingProgram);
			return Ok("Program deleted sauccessfully");
		}


	}

}
