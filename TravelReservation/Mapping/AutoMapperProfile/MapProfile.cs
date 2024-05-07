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
            CreateMap<AnnouncementAddDTOs, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDTOs, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap();
        }
    }
}
