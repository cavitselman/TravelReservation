using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.BL.Abstract;
using TravelReservation.BL.Abstract.AbstractUow;
using TravelReservation.BL.Concrete;
using TravelReservation.BL.Concrete.ConcreteUow;
using TravelReservation.BL.ValidationRules;
using TravelReservation.BL.ValidationRules.ContactUs;
using TravelReservation.DAL.Abstract;
using TravelReservation.DAL.Abstract.AbstractUow;
using TravelReservation.DAL.EntityFramework;
using TravelReservation.DAL.EntityFramework.EntityFrameworkUow;
using TravelReservation.DAL.UnitOfWork;
using TravelReservation.DTOL.DTOs.AnnouncementDTOs;
using TravelReservation.DTOL.DTOs.ContactDTOs;

namespace TravelReservation.BL.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUowDal, UowDal>();
        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
            services.AddTransient<IValidator<SendMessageDto>, SendContactUsValidator>();
        }
    }
}
