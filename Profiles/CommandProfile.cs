using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            //POST
            CreateMap<CommandCreateDto, Command>();
            //PUT
            CreateMap<CommandUpdateDto, Command>();
            //PATCH
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}