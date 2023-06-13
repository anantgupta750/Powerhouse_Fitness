using Api.BLL.DTO;

using API.Models;

using AutoMapper;

namespace Api.Mapper;

public class ApplicationMapper : Profile
{
	public ApplicationMapper()
	{
		CreateMap<User, AddUserDTO>().ReverseMap();
		CreateMap<User, AuthUserLogin>().ReverseMap();
		CreateMap<Trainer, AddTrainerDTO>().ReverseMap();
		CreateMap<TrainingProgram, AddTrainingProgramDTO>().ReverseMap();
		CreateMap<Membership, AddMembershipDTO>().ReverseMap();
	}
}
