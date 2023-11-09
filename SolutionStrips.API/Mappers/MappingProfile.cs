using AutoMapper;
using SolutionStrips.API.Models.Input;
using SolutionStrips.API.Models.Output;
using SolutionStrips.DOMAIN.Models;


namespace SolutionStrips.API.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuteurRestInputDTO, Auteur>();
            CreateMap<Auteur, AuteurRestOutputDTO>();

            CreateMap<StripRestInputDTO, Strip>();
            CreateMap<Strip, StripRestOutputDTO>();
        }
    }

}
