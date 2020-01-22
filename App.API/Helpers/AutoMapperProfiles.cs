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
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.YearsActive, opt =>
                {
                    opt.MapFrom(src => src.FoundedIn.CalculateAge());
                });
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.YearsActive, opt =>
                {
                    opt.MapFrom(src => src.FoundedIn.CalculateAge());
                });    
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<MessageForCreationDto, Message1>().ReverseMap();
            // CreateMap<User, MessageToReturnDto>()
            //     .ForMember(dest => dest.SenderKnownAs, opt =>
            //     {
            //         opt.MapFrom(src=> src.KnownAs);
            //     })
            //     .ForMember(dest => dest.RecipientKnownAs, opt =>
            //     {
            //         opt.MapFrom(src=> src.KnownAs);
            //     });    
            CreateMap<Message1, MessageToReturnDto>()
                .ForMember(m => m.SenderPhotoUrl, opt => opt
                    .MapFrom(u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(m => m.RecipientPhotoUrl, opt => opt
                    .MapFrom(u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url));
        }
    }
}