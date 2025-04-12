using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.AppUserRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ContactRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EmployeeRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.MessageRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductImageRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PropertyAmenityRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ServiceRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.StatisticsRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.SubFeatureRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.TestimonialRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.WhoWeAreRepository;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            //Singleton: projeyi ilk başlattığımızda bir instance oluşturuyor ve ilerde herhangi bir değişim olsa bile ilk oluşturduğu nesneyi kullanıyor,
            //Scoped: projeyi ilk başlattığımızda her bir istekte instance ediyor,
            //Transient: Nesneyi her çağırdığımızda veya istekte bulunduğumuz her seferinde tekarar tekrar bir instance oluşturuyor
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
