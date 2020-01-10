using System.Linq;
using AutoMapper;
using App.API.Dtos;
using App.API.Models;

namespace App.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p =>  p.IsMain).Url))

                .ForMember(dest => dest.YearsActive, opt =>
                opt.MapFrom(src => src.FoundedIn.CalculateAge()));
           
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p =>  p.IsMain).Url))

                .ForMember(dest => dest.YearsActive, opt =>
                opt.MapFrom(src => src.FoundedIn.CalculateAge()));
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
        }
    }
}