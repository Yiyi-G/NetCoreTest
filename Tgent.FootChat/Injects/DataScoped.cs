using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tgnet.Core.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Injects
{
    public static class DataScoped
    {
        public static void  BindDataInject(IServiceCollection services)
        {
            services.AddTransient<IFootChatUserRepository, FootChatUserRepository>();
            services.AddTransient<IUserServiceStateRepository, UserServiceStateRepository>();
            services.AddTransient<IRepository<Data.FootPrintImg>, FootPrintImgRepository>();
            services.AddTransient<IRepository<Data.FootPrintTag>, FootPrintTagRepository>();
            services.AddTransient<IRepository<Data.UserBusinessArea>, UserBusinessAreaRepository>();
            services.AddTransient<IRepository<Data.UserComplain>, UserComplainRepository>();
            services.AddTransient<IUserFavoriteRepository, UserFavoriteRepository>();
            services.AddTransient<IRepository<Data.UserLoginRecord>, UserLoginRecordRepository>();
            services.AddTransient<IRepository<Data.UserProduct>, UserProductRepository>();
            services.AddTransient<IRepository<Data.UserBrand>, UserBrandRepository>();
            services.AddTransient<IRepository<Data.MobileInfo>, MobileInfoRepository>();
            services.AddTransient<IRelationRepository, RelationRepository>();
            services.AddTransient<IUserSettingRepository, UserSetttingRepository>();
            services.AddTransient<IUserViewProjRecordRepository, UserViewProjRecordRepository>();
            services.AddTransient<IAddressBookMobileRepository, AddressBookMobileRepository>();
            services.AddTransient<IUserViewProjFootListRecordRepository, UserViewProjFootListRecordRepository>();
            services.AddTransient<IFootPrintRepository, FootPrintRepository>();
            services.AddTransient<ITagSourceRepository, TagSourceRepository>();
            services.AddTransient<IRepository<Data.Trade>, TradeRepository>();
            services.AddTransient<IRepository<Data.UserServiceStateUpdateRecord>, UserServiceStateUpdateRecordRepository>();
            services.AddTransient<ICallRecordRepository, CallRecordRepository>();
            services.AddTransient<IRepository<Data.UserViewFootPrintRecord>, UserViewFootPrintRecordRepository>();
            services.AddTransient<IRepository<FootPrintStatistics>, FootPrintStatisticsRepository>();
            services.AddTransient<IRepository<UserStatistics>, UserStatisticsRepository>();
            services.AddTransient<IRepository<AttentionStatistics>, AttentionStatisticsRepository>();
            services.AddTransient<IRepository<InteractionStatistics>, InteractionStatisticsRepository>();
            services.AddTransient<IRepository<DockedStatistics>, DockedStatisticsRepository>();
            services.AddTransient<IRepository<AssociatedProjRecord>, AssociatedProjRecordRepository>();
            services.AddTransient<IRepository<SuggestFeedback>, SuggestFeedbackRepository>();
            services.AddTransient<IRepository<ImportUserRecord>, ImportUserRecordRepository>();
            services.AddTransient<IRepository<ImportFootPrintRecord>, ImportFootPrintRecordRepository>();
            services.AddTransient<IRepository<InstitudeOfGrowthTrade>, InstitudeOfGrowthTradeRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDockedRecordRepository, DockedRecordRepository>();
            services.AddTransient<IRepository<Data.Class>, ClassRepository>();
            services.AddTransient<IRepository<Data.ClassStuRelation>, ClassStuRelationRepository>();
            services.AddTransient<IRepository<Data.TouristViewFootPrintRecord>, TouristViewFootPrintRecordRepository>();


            //Bind<Data.AdminDBContext>().To<InternalAdminDBContext>();
            //Bind<IRepository<AdminUser>>().To<AdminUserRepository>();
            //Bind<IRepository<ViewSysACLCache>>().To<ViewSysACLCacheRepository>();
        }
    }
}
