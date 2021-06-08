using AutoMapper;
using Dotnet_RPG.DTOs.Character;
using Dotnet_RPG.Models;

namespace Dotnet_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.HitPoints, opt => opt.MapFrom(src => src.HitPoints))
            .ForMember(dest => dest.Strength, opt => opt.MapFrom(src => src.Strength))
            .ForMember(dest => dest.Intelligence, opt => opt.MapFrom(src => src.Intelligence))
            .ForMember(dest => dest.Defense, opt => opt.MapFrom(src => src.Defense))
            .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.Class)).ReverseMap();
        }
    }
}