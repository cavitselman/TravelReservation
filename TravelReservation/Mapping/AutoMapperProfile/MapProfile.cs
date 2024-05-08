using AutoMapper;
using TravelReservation.DTOL.DTOs.AnnouncementDTOs;
using TravelReservation.DTOL.DTOs.AppUserDTOs;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDto, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDto, AppUser>().ReverseMap();

            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();

            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();
        }
    }
}
