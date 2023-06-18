using API.Context;
using API.Models;
using IdentityModel;
using System.Security.Claims;

using Microsoft.AspNetCore.Mvc;

using Api.Helper;
using Api.BLL.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Api.DAL.Interface;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;


	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private ApplicationDbContext _context;
		private readonly IConfiguration _configuration;
		private readonly IMapper _mapper;
		private readonly IUserRepository _userrepository;
		private readonly ILoginRepository _loginRepository;

		public AuthController(ApplicationDbContext context, IConfiguration configuration, IMapper mapper, IUserRepository userrepository, ILoginRepository loginRepository)
		{
			_context = context;
			_mapper = mapper;
			_userrepository = userrepository;

			_configuration = configuration;
			_loginRepository = loginRepository;

		}


		[Route("login")]
		[HttpPost]
		public IActionResult Login(AuthUserLogin loginModel)
		{

			User user = _context.UserRegistrations.Include(x => x.Roles).SingleOrDefault(x => x.Email == loginModel.Email);

			if (user is null)
				return Unauthorized("Invalid Username or Password!");

			string hashedPassword = HashPassword(loginModel.Password);
			if (BCrypt.Net.BCrypt.Verify(loginModel.Password, hashedPassword))
			{

				var token = JWT.GenerateToken(new Dictionary<string, string> {
				{ ClaimTypes.Role, user.Roles.roleName  },
				{ "RoleId", user.Roles.roleId.ToString() },
				{JwtClaimTypes.PreferredUserName, user.FirstName },
				{ JwtClaimTypes.Id, user.UserId.ToString() },
				{ JwtClaimTypes.Email, user.Email}
			}, _configuration["JWT:Key"]);

			

				return Ok(new AuthResponse { token = token, FirstName = user.FirstName , RoleId = user.Roles.roleId, UserId=user.UserId });
			}
			else
			{
				return Unauthorized("Invalid Username or Password");
			}
		}
		[Route("Registration")]
		[HttpPost]

		public async Task<IActionResult> Add([FromBody] AddUserDTO addUserDTO)
		{

			// Check if a user with the same email already exists
			var existingUser = await _loginRepository.GetByEmailAsync(addUserDTO.Email);
			if (existingUser != null)
			{
				// Return an error response indicating that the email is already registered
				return BadRequest("Email is already registered.");
			}
			//Map DTO to Domain Model           
			var userEntity = _mapper.Map<User>(addUserDTO);
			userEntity.Password = HashPassword(addUserDTO.Password);



			await _userrepository.AddAsync(userEntity);
			//var users = mapper.Map<UserDTO>(userEntity);

			return Ok(new {roleId=userEntity.roleId});
		}
		private string HashPassword(string password)
		{

			string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
			return hashedPassword;
		}
	}

